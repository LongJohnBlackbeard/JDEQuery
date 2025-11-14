using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C008 - .
/// </summary>
public class F75C008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMAN8.
        /// </summary>
        public const string EMAN8 = "EMAN8";

        /// <summary>
        /// EMC75EMPL.
        /// </summary>
        public const string EMC75EMPL = "EMC75EMPL";

        /// <summary>
        /// EMC75EMPCT.
        /// </summary>
        public const string EMC75EMPCT = "EMC75EMPCT";

        /// <summary>
        /// EMC75DOCO.
        /// </summary>
        public const string EMC75DOCO = "EMC75DOCO";

        /// <summary>
        /// EMC75DCT.
        /// </summary>
        public const string EMC75DCT = "EMC75DCT";

        /// <summary>
        /// EMDOB.
        /// </summary>
        public const string EMDOB = "EMDOB";

        /// <summary>
        /// EMDATE01.
        /// </summary>
        public const string EMDATE01 = "EMDATE01";

        /// <summary>
        /// EMDATE02.
        /// </summary>
        public const string EMDATE02 = "EMDATE02";

        /// <summary>
        /// EMC75GEND.
        /// </summary>
        public const string EMC75GEND = "EMC75GEND";

        /// <summary>
        /// EMC75EMPSTAT.
        /// </summary>
        public const string EMC75EMPSTAT = "EMC75EMPSTAT";

        /// <summary>
        /// EMC75PCID.
        /// </summary>
        public const string EMC75PCID = "EMC75PCID";

        /// <summary>
        /// EMC75PCNAM.
        /// </summary>
        public const string EMC75PCNAM = "EMC75PCNAM";

        /// <summary>
        /// EMCO.
        /// </summary>
        public const string EMCO = "EMCO";

        /// <summary>
        /// EMMCU.
        /// </summary>
        public const string EMMCU = "EMMCU";

        /// <summary>
        /// EMFUTMATH1.
        /// </summary>
        public const string EMFUTMATH1 = "EMFUTMATH1";

        /// <summary>
        /// EMFUTSTR1.
        /// </summary>
        public const string EMFUTSTR1 = "EMFUTSTR1";

        /// <summary>
        /// EMFUTSTR2.
        /// </summary>
        public const string EMFUTSTR2 = "EMFUTSTR2";

        /// <summary>
        /// EMFUTDATE1.
        /// </summary>
        public const string EMFUTDATE1 = "EMFUTDATE1";

        /// <summary>
        /// EMFUTUO1.
        /// </summary>
        public const string EMFUTUO1 = "EMFUTUO1";

        /// <summary>
        /// EMUSER.
        /// </summary>
        public const string EMUSER = "EMUSER";

        /// <summary>
        /// EMPID.
        /// </summary>
        public const string EMPID = "EMPID";

        /// <summary>
        /// EMJOBN.
        /// </summary>
        public const string EMJOBN = "EMJOBN";

        /// <summary>
        /// EMUPMJ.
        /// </summary>
        public const string EMUPMJ = "EMUPMJ";

        /// <summary>
        /// EMUPMT.
        /// </summary>
        public const string EMUPMT = "EMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75C008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMAN8", "EMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EMC75EMPL", "EMC75EMPL", JdeDataType.String, 60),
        new JdeField("EMC75EMPCT", "EMC75EMPCT", JdeDataType.String, 120),
        new JdeField("EMC75DOCO", "EMC75DOCO", JdeDataType.String, 120),
        new JdeField("EMC75DCT", "EMC75DCT", JdeDataType.String, 120),
        new JdeField("EMDOB", "EMDOB", JdeDataType.Numeric),
        new JdeField("EMDATE01", "EMDATE01", JdeDataType.Numeric),
        new JdeField("EMDATE02", "EMDATE02", JdeDataType.Numeric),
        new JdeField("EMC75GEND", "EMC75GEND", JdeDataType.String, 40),
        new JdeField("EMC75EMPSTAT", "EMC75EMPSTAT", JdeDataType.String, 2),
        new JdeField("EMC75PCID", "EMC75PCID", JdeDataType.Numeric),
        new JdeField("EMC75PCNAM", "EMC75PCNAM", JdeDataType.String, 120),
        new JdeField("EMCO", "EMCO", JdeDataType.String, 10),
        new JdeField("EMMCU", "EMMCU", JdeDataType.String, 24),
        new JdeField("EMFUTMATH1", "EMFUTMATH1", JdeDataType.Numeric),
        new JdeField("EMFUTSTR1", "EMFUTSTR1", JdeDataType.String, 100),
        new JdeField("EMFUTSTR2", "EMFUTSTR2", JdeDataType.String, 100),
        new JdeField("EMFUTDATE1", "EMFUTDATE1", JdeDataType.Numeric),
        new JdeField("EMFUTUO1", "EMFUTUO1", JdeDataType.String, 2),
        new JdeField("EMUSER", "EMUSER", JdeDataType.String, 20),
        new JdeField("EMPID", "EMPID", JdeDataType.String, 20),
        new JdeField("EMJOBN", "EMJOBN", JdeDataType.String, 20),
        new JdeField("EMUPMJ", "EMUPMJ", JdeDataType.Numeric),
        new JdeField("EMUPMT", "EMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C008_0", "Primary Key on EMAN8", new[] { "EMAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
