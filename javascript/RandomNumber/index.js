module.exports = async function (context, req) {
  context.log("JavaScript HTTP trigger function processed a request.");
  const max = parseInt(req.query.max) || 100;

  context.res = {
    body: {
      status: "ok",
      max,
      random: Math.floor(Math.random() * max) + 1,
    },
  };
};
