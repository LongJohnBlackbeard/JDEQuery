using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F151521 - .
/// </summary>
public class F151521 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LODOCO.
        /// </summary>
        public const string LODOCO = "LODOCO";

        /// <summary>
        /// LOLSVR.
        /// </summary>
        public const string LOLSVR = "LOLSVR";

        /// <summary>
        /// LOBCI.
        /// </summary>
        public const string LOBCI = "LOBCI";

        /// <summary>
        /// LOCAPID.
        /// </summary>
        public const string LOCAPID = "LOCAPID";

        /// <summary>
        /// LOMCU.
        /// </summary>
        public const string LOMCU = "LOMCU";

        /// <summary>
        /// LOOBJ.
        /// </summary>
        public const string LOOBJ = "LOOBJ";

        /// <summary>
        /// LOSUB.
        /// </summary>
        public const string LOSUB = "LOSUB";

        /// <summary>
        /// LOAID.
        /// </summary>
        public const string LOAID = "LOAID";

        /// <summary>
        /// LOCAPOVTY.
        /// </summary>
        public const string LOCAPOVTY = "LOCAPOVTY";

        /// <summary>
        /// LOSTCAP.
        /// </summary>
        public const string LOSTCAP = "LOSTCAP";

        /// <summary>
        /// LOEPCL.
        /// </summary>
        public const string LOEPCL = "LOEPCL";

        /// <summary>
        /// LORMK.
        /// </summary>
        public const string LORMK = "LORMK";

        /// <summary>
        /// LOURCD.
        /// </summary>
        public const string LOURCD = "LOURCD";

        /// <summary>
        /// LOURDT.
        /// </summary>
        public const string LOURDT = "LOURDT";

        /// <summary>
        /// LOURAT.
        /// </summary>
        public const string LOURAT = "LOURAT";

        /// <summary>
        /// LOURAB.
        /// </summary>
        public const string LOURAB = "LOURAB";

        /// <summary>
        /// LOURRF.
        /// </summary>
        public const string LOURRF = "LOURRF";

        /// <summary>
        /// LOUSER.
        /// </summary>
        public const string LOUSER = "LOUSER";

        /// <summary>
        /// LOPID.
        /// </summary>
        public const string LOPID = "LOPID";

        /// <summary>
        /// LOMKEY.
        /// </summary>
        public const string LOMKEY = "LOMKEY";

        /// <summary>
        /// LOUPMJ.
        /// </summary>
        public const string LOUPMJ = "LOUPMJ";

        /// <summary>
        /// LOUPMT.
        /// </summary>
        public const string LOUPMT = "LOUPMT";

        /// <summary>
        /// LOTORG.
        /// </summary>
        public const string LOTORG = "LOTORG";

        /// <summary>
        /// LOENTJ.
        /// </summary>
        public const string LOENTJ = "LOENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F151521";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LODOCO", "LODOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("LOLSVR", "LOLSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("LOBCI", "LOBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("LOCAPID", "LOCAPID", JdeDataType.String, 20, true, true),
        new JdeField("LOMCU", "LOMCU", JdeDataType.String, 24, true, true),
        new JdeField("LOOBJ", "LOOBJ", JdeDataType.String, 12, true, true),
        new JdeField("LOSUB", "LOSUB", JdeDataType.String, 16, true, true),
        new JdeField("LOAID", "LOAID", JdeDataType.String, 16),
        new JdeField("LOCAPOVTY", "LOCAPOVTY", JdeDataType.String, 2),
        new JdeField("LOSTCAP", "LOSTCAP", JdeDataType.String, 2),
        new JdeField("LOEPCL", "LOEPCL", JdeDataType.String, 8),
        new JdeField("LORMK", "LORMK", JdeDataType.String, 60),
        new JdeField("LOURCD", "LOURCD", JdeDataType.String, 4),
        new JdeField("LOURDT", "LOURDT", JdeDataType.Numeric),
        new JdeField("LOURAT", "LOURAT", JdeDataType.Numeric),
        new JdeField("LOURAB", "LOURAB", JdeDataType.Numeric),
        new JdeField("LOURRF", "LOURRF", JdeDataType.String, 30),
        new JdeField("LOUSER", "LOUSER", JdeDataType.String, 20),
        new JdeField("LOPID", "LOPID", JdeDataType.String, 20),
        new JdeField("LOMKEY", "LOMKEY", JdeDataType.String, 30),
        new JdeField("LOUPMJ", "LOUPMJ", JdeDataType.Numeric),
        new JdeField("LOUPMT", "LOUPMT", JdeDataType.Numeric),
        new JdeField("LOTORG", "LOTORG", JdeDataType.String, 20),
        new JdeField("LOENTJ", "LOENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F151521_0", "Primary Key on LODOCO, LOLSVR, LOBCI, LOCAPID, LOMCU, LOOBJ, LOSUB", new[] { "LODOCO", "LOLSVR", "LOBCI", "LOCAPID", "LOMCU", "LOOBJ", "LOSUB" }, isUnique: true, isPrimaryKey: true)
    };
}
