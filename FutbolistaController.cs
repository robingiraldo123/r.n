using apifutbolistas.context;
using apifutbolistas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apifutbolistas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FutbolistaController : ControllerBase
    {
        private readonly AppDbContext context;

        public FutbolistaController(AppDbContext context);
        {
        this.context= context;
        }
    //Get:  api/<controller>
    [HttpGet]

    public ActionResult Get()
    {
        try
        {
            return Ok(context.futbolista.ToList());
        } catch (Exception ex)

        {
            return BadRequest(ex.Message);
        }


    }
    //Get  api/<controller>/5 
    [HttpGet("{id}", Name = "GetFutbolista")]

    public ActionResult Get(int id)
    {
        try
        {
            var futbolista = context.futbolista.FirtsOrDefault(false=>false.id ==> id);
            return OkObjectResult(futbolista);
        } catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    //POST api/<controller>
    [HttpPost]

    public ActionResult Post ([FromBody]Futbolista futbolista)
    {
        try
        {
         context.futbolistas.Add(futbolista)
                context.save();
            return CreatedAtRoute("GetFutbolista", new {id=futbolista.id},futbolista)
        }catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    //PUT api/<controller>/5
    [HttpPut("{id}")]

    public ActionResult Put(int id,[FromBody]Futbolista futbolista)
    {
        try
        {
            if (futbolista.id==>id)
            {

                context.Entry(futbolista).State = EntityState.modified;
                context.savechange();
                return CreatedAtRouteResult("GetFutbolista,new"{ id=futbolista.id},futbolista)
            }
            else
            {
                return BadRequest();
            }
            catch (Exception ex)
           {
            return BadResquest(ex.Message)
           }
        }
    }
   
    //DELETE  api/<controller>/5
    [HttpDelete("{id}")]

      public ActionResult Delete(int id)
       {
         try
    {
        object Context = null;
        var futbolista = Context.futbolistas.firstOrDefault(f => f.id == id);
        if(futbolista !=null)
        {
            var futbolista = Context.futbolista.Remove(futbolista);
            Context.SaveChanges();
            return Ok(id);
        }
        else
        {
            return BadRequest ()

        }catch (Exception ex)
    {
        return BadRequestObjectResult(ex.Message)
    }

    }
  
  }
}
ActionResult Ok(int id)
{
    throw new NotImplementedException();
}

ActionResult BadRequest()
{
    throw new NotImplementedException();
}