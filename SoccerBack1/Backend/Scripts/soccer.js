$(document).ready(function () {
    $("#LeagueId").change(function () {
        $("#TeamId").empty();
        $.ajax({
            type: 'POST',
            url: Url,
            dataType: 'json',
            data: { leagueId: $("#LeagueId").val() },
            success: function (teams) {
                $.each(teams, function (i, team) {
                    $("#TeamId").append('<option value="'
                     + team.TeamId + '">'
                     + team.Name + '</option>');
                });
            },
            error: function (ex) {
                alert('Error en recuperar los equipos.' + ex);
            }
        });
        return false;
    });
});

$(document).ready(function () {
    $("#LocalLeagueId").change(function () {
        $("#LocalId").empty();
        $.ajax({
            type: 'POST',
            url: Url,
            dataType: 'json',
            data: { leagueId: $("#LocalLeagueId").val() },
            success: function (teams) {
                $.each(teams, function (i, team) {
                    $("#LocalId").append('<option value="'
                     + team.TeamId + '">'
                     + team.Name + '</option>');
                });
            },
            error: function (ex) {
                alert('Error en recuperar los equipos.' + ex);
            }
        });
        return false;
    });
});

$(document).ready(function () {
    $("#VisitorLeagueId").change(function () {
        $("#VisitorId").empty();
        $.ajax({
            type: 'POST',
            url: Url,
            dataType: 'json',
            data: { leagueId: $("#VisitorLeagueId").val() },
            success: function (teams) {
                $.each(teams, function (i, team) {
                    $("#VisitorId").append('<option value="'
                     + team.TeamId + '">'
                     + team.Name + '</option>');
                });
            },
            error: function (ex) {
                alert('Error en recuperar los equipos.' + ex);
            }
        });
        return false;
    });
});

$(document).ready(function () {
    $("#FavoriteLeagueId").change(function () {
        $("#FavoriteTeamId").empty();
        $.ajax({
            type: 'POST',
            url: Url,
            dataType: 'json',
            data: { leagueId: $("#FavoriteLeagueId").val() },
            success: function (teams) {
                $.each(teams, function (i, team) {
                    $("#FavoriteTeamId").append('<option value="'
                     + team.TeamId + '">'
                     + team.Name + '</option>');
                });
            },
            error: function (ex) {
                alert('Error en recuperar los equipos.' + ex);
            }
        });
        return false;
    });
});