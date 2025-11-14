using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F085530W - .
/// </summary>
public class F085530WModel
{
    /// <summary>
    /// CPAN8 (Primary Key).
    /// </summary>
    public decimal CPAN8 { get; set; }

    /// <summary>
    /// CPSEQ# (Primary Key).
    /// </summary>
    [Column("CPSEQ#")]
    public decimal CPSEQ_ { get; set; }

    /// <summary>
    /// CPSBGR (Primary Key).
    /// </summary>
    public string CPSBGR { get; set; }

    /// <summary>
    /// CPDL01.
    /// </summary>
    public string? CPDL01 { get; set; }

    /// <summary>
    /// CPPLAN (Primary Key).
    /// </summary>
    public string CPPLAN { get; set; }

    /// <summary>
    /// CPAOPT (Primary Key).
    /// </summary>
    public string CPAOPT { get; set; }

    /// <summary>
    /// CPDS50.
    /// </summary>
    public string? CPDS50 { get; set; }

    /// <summary>
    /// CPEFT (Primary Key).
    /// </summary>
    public decimal CPEFT { get; set; }

    /// <summary>
    /// CPEFTE.
    /// </summary>
    public decimal? CPEFTE { get; set; }

    /// <summary>
    /// CPPCOS.
    /// </summary>
    public decimal? CPPCOS { get; set; }

    /// <summary>
    /// CPPCRE.
    /// </summary>
    public decimal? CPPCRE { get; set; }

    /// <summary>
    /// CPDBEN.
    /// </summary>
    public string? CPDBEN { get; set; }

    /// <summary>
    /// CPPCPF.
    /// </summary>
    public decimal? CPPCPF { get; set; }

    /// <summary>
    /// CPPCPVST.
    /// </summary>
    public string? CPPCPVST { get; set; }

    /// <summary>
    /// CPEEFC.
    /// </summary>
    public decimal? CPEEFC { get; set; }

    /// <summary>
    /// CPERAM.
    /// </summary>
    public decimal? CPERAM { get; set; }

    /// <summary>
    /// CPBRTM.
    /// </summary>
    public decimal? CPBRTM { get; set; }

    /// <summary>
    /// CPDRTM.
    /// </summary>
    public decimal? CPDRTM { get; set; }

    /// <summary>
    /// CPCATY.
    /// </summary>
    public string? CPCATY { get; set; }

    /// <summary>
    /// CPPID.
    /// </summary>
    public string? CPPID { get; set; }

    /// <summary>
    /// CPUPMJ.
    /// </summary>
    public decimal? CPUPMJ { get; set; }

    /// <summary>
    /// CPUPMT.
    /// </summary>
    public decimal? CPUPMT { get; set; }

    /// <summary>
    /// CPUSER.
    /// </summary>
    public string? CPUSER { get; set; }

    /// <summary>
    /// CPSEQN.
    /// </summary>
    public decimal? CPSEQN { get; set; }

    /// <summary>
    /// CPJOBN.
    /// </summary>
    public string? CPJOBN { get; set; }

    /// <summary>
    /// CPBCATCL.
    /// </summary>
    public string? CPBCATCL { get; set; }

    /// <summary>
    /// CPPLNGRP.
    /// </summary>
    public string? CPPLNGRP { get; set; }

    /// <summary>
    /// CPPCP#.
    /// </summary>
    [Column("CPPCP#")]
    public string? CPPCP_ { get; set; }

    /// <summary>
    /// CPSIPG.
    /// </summary>
    public string? CPSIPG { get; set; }

    /// <summary>
    /// CPNPPLFL.
    /// </summary>
    public string? CPNPPLFL { get; set; }
}
