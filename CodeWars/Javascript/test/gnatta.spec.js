const {assert} = require("chai");
const {fixture} = require("./fixtures/gnatta.fixture");
const {calculateScores} = require("../src/gnatta/gnatta");

describe("Gnatta", () => {
  it("Creates correct scores object", () => {
    const scores = calculateScores();

    assert.equal(scores.totalScores, fixture.totalScores);
    assert.equal(scores.averageScore, fixture.averageScore);
    assert.deepEqual(scores, fixture);
  });
});