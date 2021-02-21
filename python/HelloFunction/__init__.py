import logging
import azure.functions as func
import json


def main(req: func.HttpRequest) -> func.HttpResponse:
    logging.info('[HTTP] Hello function processed a request.')
    name = req.params.get('name')
    if name:
        return func.HttpResponse(
            json.dumps({
                "status": "ok",
                "message": f"Hello, {name}."
            })
        )
    else:
        return func.HttpResponse(
            json.dumps({
                "status": "ok",
                "message": "A name was not passed with the params"
            })
        )
