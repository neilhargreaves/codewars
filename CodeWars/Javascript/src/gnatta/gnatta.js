const {countBy, uniqBy, sortBy} = require('lodash');
const {players, scores} = require('./data');

let totalScoreValue = 0;

const calculateScores = () => {
  totalScoreValue = 0;
  const mappedScores = uniqBy(mapScoreToPlayer(), x => x.id);

  return {
    'scores': sortBy(mappedScores, x => x.id),
    'totalScores': scores.list.length,
    'averageScore': totalScoreValue / scores.list.length
  };
};

const mapScoreToPlayer = () => {
  const scoresSubmitted = countBy(scores.list, score => score.userId);

  return scores.list.map(score => {
    const player = players.list.find(x => x.id === score.userId);
    const scoreSubmitted = scoresSubmitted[score.userId];

    totalScoreValue += score.score;

    return {
      'id': score.userId,
      'name': player.name,
      'scoresSubmitted': scoreSubmitted
    }
  });
};

module.exports = {
  calculateScores
};