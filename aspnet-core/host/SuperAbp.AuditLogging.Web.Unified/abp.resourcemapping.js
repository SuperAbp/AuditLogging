module.exports = {
    aliases: {
        "@node_modules": "./node_modules",
        "@libs": "./wwwroot/libs"
    },
    clean: [
        "@libs"
    ],
    mappings: {
        "@node_modules/daterangepicker/daterangepicker.js": "@libs/daterangepicker/",
        "@node_modules/daterangepicker/daterangepicker.css": "@libs/daterangepicker/",
        "@node_modules/moment/dist/moment.js": "@libs/moment/",
        "@node_modules/moment/min/*.*": "@libs/moment/min/",
        "@node_modules/moment/dist/locale/*.*": "@libs/moment/locale/",
        "@node_modules/select2-bootstrap-5-theme/dist/*.*": "@libs/select2-bootstrap5-theme",
        "@node_modules/select2-bootstrap-5-theme/dist/*.*.*": "@libs/select2-bootstrap5-theme",
        "@node_modules/select2-bootstrap-5-theme/dist/*.*.*.*": "@libs/select2-bootstrap5-theme"
    }
}