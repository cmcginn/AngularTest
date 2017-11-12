angular
    .module('myApp')
    .constant('apiEndpoints',
        {
            labOrderList: '/api/labOrderList'
        }).constant('directiveTemplates',
        {
            labOrderListViewControl: '/scripts/app/directives/templates/lab-order-list-view-control.html'
        });