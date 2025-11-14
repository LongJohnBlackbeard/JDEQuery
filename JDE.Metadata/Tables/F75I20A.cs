using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I20A - .
/// </summary>
public class F75I20A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QDCO.
        /// </summary>
        public const string QDCO = "QDCO";

        /// <summary>
        /// QDKCO.
        /// </summary>
        public const string QDKCO = "QDKCO";

        /// <summary>
        /// QDYGRP.
        /// </summary>
        public const string QDYGRP = "QDYGRP";

        /// <summary>
        /// QDI75ORST.
        /// </summary>
        public const string QDI75ORST = "QDI75ORST";

        /// <summary>
        /// QDI75PEBE.
        /// </summary>
        public const string QDI75PEBE = "QDI75PEBE";

        /// <summary>
        /// QDI75PEEN.
        /// </summary>
        public const string QDI75PEEN = "QDI75PEEN";

        /// <summary>
        /// QDAPAY.
        /// </summary>
        public const string QDAPAY = "QDAPAY";

        /// <summary>
        /// QDYDNM.
        /// </summary>
        public const string QDYDNM = "QDYDNM";

        /// <summary>
        /// QDYAD1.
        /// </summary>
        public const string QDYAD1 = "QDYAD1";

        /// <summary>
        /// QDYAD2.
        /// </summary>
        public const string QDYAD2 = "QDYAD2";

        /// <summary>
        /// QDYAD3.
        /// </summary>
        public const string QDYAD3 = "QDYAD3";

        /// <summary>
        /// QDYAD4.
        /// </summary>
        public const string QDYAD4 = "QDYAD4";

        /// <summary>
        /// QDYPN1.
        /// </summary>
        public const string QDYPN1 = "QDYPN1";

        /// <summary>
        /// QDYPN2.
        /// </summary>
        public const string QDYPN2 = "QDYPN2";

        /// <summary>
        /// QDYPN3.
        /// </summary>
        public const string QDYPN3 = "QDYPN3";

        /// <summary>
        /// QDYIT1.
        /// </summary>
        public const string QDYIT1 = "QDYIT1";

        /// <summary>
        /// QDYIT2.
        /// </summary>
        public const string QDYIT2 = "QDYIT2";

        /// <summary>
        /// QDYIT3.
        /// </summary>
        public const string QDYIT3 = "QDYIT3";

        /// <summary>
        /// QDYIT4.
        /// </summary>
        public const string QDYIT4 = "QDYIT4";

        /// <summary>
        /// QDYTN1.
        /// </summary>
        public const string QDYTN1 = "QDYTN1";

        /// <summary>
        /// QDYTN2.
        /// </summary>
        public const string QDYTN2 = "QDYTN2";

        /// <summary>
        /// QDYTN3.
        /// </summary>
        public const string QDYTN3 = "QDYTN3";

        /// <summary>
        /// QDYSGN.
        /// </summary>
        public const string QDYSGN = "QDYSGN";

        /// <summary>
        /// QDYSPL.
        /// </summary>
        public const string QDYSPL = "QDYSPL";

        /// <summary>
        /// QDYDSG.
        /// </summary>
        public const string QDYDSG = "QDYDSG";

        /// <summary>
        /// QDUSER.
        /// </summary>
        public const string QDUSER = "QDUSER";

        /// <summary>
        /// QDPID.
        /// </summary>
        public const string QDPID = "QDPID";

        /// <summary>
        /// QDJOBN.
        /// </summary>
        public const string QDJOBN = "QDJOBN";

        /// <summary>
        /// QDCDT.
        /// </summary>
        public const string QDCDT = "QDCDT";

        /// <summary>
        /// QDUPMJ.
        /// </summary>
        public const string QDUPMJ = "QDUPMJ";

        /// <summary>
        /// QDUPMT.
        /// </summary>
        public const string QDUPMT = "QDUPMT";

        /// <summary>
        /// QDTORG.
        /// </summary>
        public const string QDTORG = "QDTORG";

        /// <summary>
        /// QDFLAG.
        /// </summary>
        public const string QDFLAG = "QDFLAG";

        /// <summary>
        /// QDI75PCFG.
        /// </summary>
        public const string QDI75PCFG = "QDI75PCFG";

        /// <summary>
        /// QDI75TRN1.
        /// </summary>
        public const string QDI75TRN1 = "QDI75TRN1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I20A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QDCO", "QDCO", JdeDataType.String, 10, true, true),
        new JdeField("QDKCO", "QDKCO", JdeDataType.String, 10, true, true),
        new JdeField("QDYGRP", "QDYGRP", JdeDataType.String, 2, true, true),
        new JdeField("QDI75ORST", "QDI75ORST", JdeDataType.String, 6, true, true),
        new JdeField("QDI75PEBE", "QDI75PEBE", JdeDataType.Numeric),
        new JdeField("QDI75PEEN", "QDI75PEEN", JdeDataType.Numeric),
        new JdeField("QDAPAY", "QDAPAY", JdeDataType.Numeric),
        new JdeField("QDYDNM", "QDYDNM", JdeDataType.String, 80),
        new JdeField("QDYAD1", "QDYAD1", JdeDataType.String, 80),
        new JdeField("QDYAD2", "QDYAD2", JdeDataType.String, 80),
        new JdeField("QDYAD3", "QDYAD3", JdeDataType.String, 80),
        new JdeField("QDYAD4", "QDYAD4", JdeDataType.String, 80),
        new JdeField("QDYPN1", "QDYPN1", JdeDataType.String, 80),
        new JdeField("QDYPN2", "QDYPN2", JdeDataType.String, 80),
        new JdeField("QDYPN3", "QDYPN3", JdeDataType.String, 80),
        new JdeField("QDYIT1", "QDYIT1", JdeDataType.String, 80),
        new JdeField("QDYIT2", "QDYIT2", JdeDataType.String, 80),
        new JdeField("QDYIT3", "QDYIT3", JdeDataType.String, 80),
        new JdeField("QDYIT4", "QDYIT4", JdeDataType.String, 80),
        new JdeField("QDYTN1", "QDYTN1", JdeDataType.String, 80),
        new JdeField("QDYTN2", "QDYTN2", JdeDataType.String, 80),
        new JdeField("QDYTN3", "QDYTN3", JdeDataType.String, 80),
        new JdeField("QDYSGN", "QDYSGN", JdeDataType.String, 80),
        new JdeField("QDYSPL", "QDYSPL", JdeDataType.String, 80),
        new JdeField("QDYDSG", "QDYDSG", JdeDataType.String, 80),
        new JdeField("QDUSER", "QDUSER", JdeDataType.String, 20),
        new JdeField("QDPID", "QDPID", JdeDataType.String, 20),
        new JdeField("QDJOBN", "QDJOBN", JdeDataType.String, 20),
        new JdeField("QDCDT", "QDCDT", JdeDataType.Numeric),
        new JdeField("QDUPMJ", "QDUPMJ", JdeDataType.Numeric),
        new JdeField("QDUPMT", "QDUPMT", JdeDataType.Numeric),
        new JdeField("QDTORG", "QDTORG", JdeDataType.String, 20),
        new JdeField("QDFLAG", "QDFLAG", JdeDataType.String, 2),
        new JdeField("QDI75PCFG", "QDI75PCFG", JdeDataType.String, 2),
        new JdeField("QDI75TRN1", "QDI75TRN1", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I20A_0", "Primary Key on QDCO, QDKCO, QDYGRP, QDI75ORST", new[] { "QDCO", "QDKCO", "QDYGRP", "QDI75ORST" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I20A_2", "Index on QDI75PCFG, QDKCO, QDYGRP, QDI75ORST", new[] { "QDI75PCFG", "QDKCO", "QDYGRP", "QDI75ORST" }),
        new JdeIndex("F75I20A_3", "Index on QDCO, QDKCO, QDYGRP, QDI75PEBE, QDI75PEEN", new[] { "QDCO", "QDKCO", "QDYGRP", "QDI75PEBE", "QDI75PEEN" })
    };
}
