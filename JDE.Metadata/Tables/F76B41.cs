using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B41 - .
/// </summary>
public class F76B41 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ISCO.
        /// </summary>
        public const string ISCO = "ISCO";

        /// <summary>
        /// ISBRINM.
        /// </summary>
        public const string ISBRINM = "ISBRINM";

        /// <summary>
        /// ISBRSSR.
        /// </summary>
        public const string ISBRSSR = "ISBRSSR";

        /// <summary>
        /// ISBRNNF.
        /// </summary>
        public const string ISBRNNF = "ISBRNNF";

        /// <summary>
        /// ISAT1.
        /// </summary>
        public const string ISAT1 = "ISAT1";

        /// <summary>
        /// ISAN8.
        /// </summary>
        public const string ISAN8 = "ISAN8";

        /// <summary>
        /// ISPRSC.
        /// </summary>
        public const string ISPRSC = "ISPRSC";

        /// <summary>
        /// ISDESC.
        /// </summary>
        public const string ISDESC = "ISDESC";

        /// <summary>
        /// ISSSCH.
        /// </summary>
        public const string ISSSCH = "ISSSCH";

        /// <summary>
        /// ISAEXP.
        /// </summary>
        public const string ISAEXP = "ISAEXP";

        /// <summary>
        /// ISDSCT.
        /// </summary>
        public const string ISDSCT = "ISDSCT";

        /// <summary>
        /// ISBRPICM.
        /// </summary>
        public const string ISBRPICM = "ISBRPICM";

        /// <summary>
        /// ISBBCL.
        /// </summary>
        public const string ISBBCL = "ISBBCL";

        /// <summary>
        /// ISBICP.
        /// </summary>
        public const string ISBICP = "ISBICP";

        /// <summary>
        /// ISDOCO.
        /// </summary>
        public const string ISDOCO = "ISDOCO";

        /// <summary>
        /// ISFTOT.
        /// </summary>
        public const string ISFTOT = "ISFTOT";

        /// <summary>
        /// ISUSER.
        /// </summary>
        public const string ISUSER = "ISUSER";

        /// <summary>
        /// ISEAP.
        /// </summary>
        public const string ISEAP = "ISEAP";

        /// <summary>
        /// ISJOBN.
        /// </summary>
        public const string ISJOBN = "ISJOBN";

        /// <summary>
        /// ISUPMJ.
        /// </summary>
        public const string ISUPMJ = "ISUPMJ";

        /// <summary>
        /// ISUPMT.
        /// </summary>
        public const string ISUPMT = "ISUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B41";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ISCO", "ISCO", JdeDataType.String, 10, true, true),
        new JdeField("ISBRINM", "ISBRINM", JdeDataType.String, 2, true, true),
        new JdeField("ISBRSSR", "ISBRSSR", JdeDataType.String, 10, true, true),
        new JdeField("ISBRNNF", "ISBRNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("ISAT1", "ISAT1", JdeDataType.String, 6, true, true),
        new JdeField("ISAN8", "ISAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ISPRSC", "ISPRSC", JdeDataType.String, 4),
        new JdeField("ISDESC", "ISDESC", JdeDataType.String, 60),
        new JdeField("ISSSCH", "ISSSCH", JdeDataType.Numeric),
        new JdeField("ISAEXP", "ISAEXP", JdeDataType.Numeric),
        new JdeField("ISDSCT", "ISDSCT", JdeDataType.Numeric),
        new JdeField("ISBRPICM", "ISBRPICM", JdeDataType.Numeric),
        new JdeField("ISBBCL", "ISBBCL", JdeDataType.Numeric),
        new JdeField("ISBICP", "ISBICP", JdeDataType.Numeric),
        new JdeField("ISDOCO", "ISDOCO", JdeDataType.Numeric),
        new JdeField("ISFTOT", "ISFTOT", JdeDataType.Numeric),
        new JdeField("ISUSER", "ISUSER", JdeDataType.String, 20),
        new JdeField("ISEAP", "ISEAP", JdeDataType.String, 20),
        new JdeField("ISJOBN", "ISJOBN", JdeDataType.String, 20),
        new JdeField("ISUPMJ", "ISUPMJ", JdeDataType.Numeric),
        new JdeField("ISUPMT", "ISUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B41_0", "Primary Key on ISCO, ISBRINM, ISBRSSR, ISBRNNF, ISAT1, ISAN8", new[] { "ISCO", "ISBRINM", "ISBRSSR", "ISBRNNF", "ISAT1", "ISAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
