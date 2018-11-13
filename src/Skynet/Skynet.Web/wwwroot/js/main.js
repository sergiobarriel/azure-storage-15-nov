 var app = new Vue({
    el: '#app',
    data: {

        static : {
            company : {
                name : 'Cyberdyne Systems',
                address_one : 'El Camino Real, Sunnyvale, California.',
                address_two : '33522'
            },
            welcome : "Welcome to Skynet Management Portal",
            robots : "Robots",
            target : "Target Sarah Connor",
            scan : "Scan mode ",
            connecting : 'Connecting...',
            captured : 'Captured on',
            doomsday : 'Start doomsday!',
            empty : 'Live View is not available'
        },

        parameters : {
            basePath : 'http://skynet-ciber.azurewebsites.net/api/',
            broadcastIntervalTime : 3000,
            broadcastInterval : 0,
            progress : false,
            empty : false,
        },

        robots : [],
        capture : {},
    },

    created : function(){
        axios
        .get(this.parameters.basePath + 'robot')
        .then(response => (this.robots = response.data))
    },
 
    methods: {
        getRobots : function () {
            axios
            .get(this.parameters.basePath + 'robot')
            .then(response => (this.robots = response.data));
        },

        startCaptureBroadcast : function (robotId) {
        
            this.resetInterval();

            this.parameters.progress = true;

            this.broadcastInterval = setInterval(function(){
                axios
                .get(this.parameters.basePath + 'robot/' + robotId + '/capture/last')
                .then(response => {
                    
                    if(response.status == 200) {
                        this.capture = response.data;
                        this.parameters.empty = false;
                    }
                    else {
                        this.parameters.empty = true;
                    }
                });
                
                this.parameters.progress = false;                

            }.bind(this), this.parameters.broadcastIntervalTime);

        },

        resetInterval : function() {
            if(this.parameters.broadcastInterval != undefined) {                
                window.clearInterval(this.parameters.broadcastInterval);
            }
        },

        getRandomNumber : function() {
            return Math.floor(Math.random(9) * 1000000);
        },

    },

})

