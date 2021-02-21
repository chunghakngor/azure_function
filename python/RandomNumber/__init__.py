import logging
import azure.functions as func
import json
import random


def main(req: func.HttpRequest) -> func.HttpResponse:
    logging.info('[HTTP] Random number function processed a request.')
    try:
        max = int(req.params.get('max'))
    except:
        max = 100
    finally:
        outputNumber = random.randint(0, max)

    return func.HttpResponse(
        status_code = 200,
        body = json.dumps({
            "status": "ok",
            "max": max,
            "random": outputNumber
        })
    )
