﻿using System;
using System.Collections.Generic;

namespace SimuRails.Models
{
    public class Estacion
    {
        public Estacion()
        {
            this.TiempoComprometidoSentidoVuelta = 0;
            this.TiempoComprometidoSentidoIda = 0;
            Incidentes = new List<Incidente>();
            Relaciones = new List<Relacion>();
        }


        public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }
        public virtual int PersonasEsperandoMax { get; set; }
        public virtual int PersonasEsperandoMin { get; set; }
        public virtual string TipoFDP { get; set; } //TODO: Acá no sé de qué tipo es. Quizá se pueda hacer un enum

        public virtual IList<Incidente> Incidentes { get; set; }
        public virtual IList<Relacion> Relaciones { get; set; }

        public virtual int TiempoComprometidoSentidoIda { get; set; }
        public virtual int TiempoComprometidoSentidoVuelta { get; set; }

        //TODO: Implementar en funcion de la FDP
        public virtual int pasajerosDescendidos(Estacion e, int t)
        {
            throw new NotImplementedException();
        }

        //TODO: Implementar en funcion de la FDP
        public virtual int pasajerosAscendidos(Estacion e, int t)
        {
            throw new NotImplementedException();
        }

        public virtual int getTiempoAtencion(int p)
        {
            throw new NotImplementedException();
        }

        public virtual List<Incidente> getIncidentes()
        {
            throw new NotImplementedException();
        }

        public virtual int getTiempoComprometido(Formacion.Sentido sentido)
        {
            return sentido == Formacion.Sentido.IDA ? TiempoComprometidoSentidoIda : TiempoComprometidoSentidoVuelta;
        }

        public virtual void setTiempoComprometido(Formacion.Sentido sentido, int tiempoComprometido)
        {
            if (sentido == Formacion.Sentido.IDA)
            {
                TiempoComprometidoSentidoIda = tiempoComprometido;
            }
            else
            {
                TiempoComprometidoSentidoVuelta = tiempoComprometido;
            }
        }

        public virtual void addTiempoComprometido(Formacion.Sentido sentido, int tiempoComprometido)
        {
            if (sentido == Formacion.Sentido.IDA)
            {
                TiempoComprometidoSentidoIda += tiempoComprometido;
            }
            else
            {
                TiempoComprometidoSentidoVuelta += tiempoComprometido;
            }
        }
    }
}