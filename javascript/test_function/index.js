// config for methods and auth is config in function.json

module.exports = async function (context, req) {
  context.log("[INFO] HTTP trigger function processed a request.");
  const name = req.query.name || (req.body && req.body.name);

  /** if there is name inside the query string or in the request body, then will return the message below
   *  Otherwise, it will return that the message was triggered but there was no name or string
   */
  const responseMessage = name
    ? `Hello, ${name}. This HTTP triggered function executed successfully.`
    : "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response.";

  context.res = {
    status: 200,
    body: responseMessage,
  };
};
