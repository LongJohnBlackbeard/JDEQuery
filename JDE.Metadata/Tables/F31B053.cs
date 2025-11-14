using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B053 - .
/// </summary>
public class F31B053 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CAMCU.
        /// </summary>
        public const string CAMCU = "CAMCU";

        /// <summary>
        /// CAWOPID.
        /// </summary>
        public const string CAWOPID = "CAWOPID";

        /// <summary>
        /// CAEQPID.
        /// </summary>
        public const string CAEQPID = "CAEQPID";

        /// <summary>
        /// CAITM.
        /// </summary>
        public const string CAITM = "CAITM";

        /// <summary>
        /// CAWCALN.
        /// </summary>
        public const string CAWCALN = "CAWCALN";

        /// <summary>
        /// CAUSGRATE.
        /// </summary>
        public const string CAUSGRATE = "CAUSGRATE";

        /// <summary>
        /// CAECQTY.
        /// </summary>
        public const string CAECQTY = "CAECQTY";

        /// <summary>
        /// CAUOM1.
        /// </summary>
        public const string CAUOM1 = "CAUOM1";

        /// <summary>
        /// CALOCN.
        /// </summary>
        public const string CALOCN = "CALOCN";

        /// <summary>
        /// CALOTN.
        /// </summary>
        public const string CALOTN = "CALOTN";

        /// <summary>
        /// CAURAB.
        /// </summary>
        public const string CAURAB = "CAURAB";

        /// <summary>
        /// CAURAT.
        /// </summary>
        public const string CAURAT = "CAURAT";

        /// <summary>
        /// CAURCD.
        /// </summary>
        public const string CAURCD = "CAURCD";

        /// <summary>
        /// CAURDT.
        /// </summary>
        public const string CAURDT = "CAURDT";

        /// <summary>
        /// CAURRF.
        /// </summary>
        public const string CAURRF = "CAURRF";

        /// <summary>
        /// CAUSER.
        /// </summary>
        public const string CAUSER = "CAUSER";

        /// <summary>
        /// CAUPMJ.
        /// </summary>
        public const string CAUPMJ = "CAUPMJ";

        /// <summary>
        /// CAUPMT.
        /// </summary>
        public const string CAUPMT = "CAUPMT";

        /// <summary>
        /// CAJOBN.
        /// </summary>
        public const string CAJOBN = "CAJOBN";

        /// <summary>
        /// CAMKEY.
        /// </summary>
        public const string CAMKEY = "CAMKEY";

        /// <summary>
        /// CAPID.
        /// </summary>
        public const string CAPID = "CAPID";

        /// <summary>
        /// CAQTST.
        /// </summary>
        public const string CAQTST = "CAQTST";

        /// <summary>
        /// CAWRF.
        /// </summary>
        public const string CAWRF = "CAWRF";

        /// <summary>
        /// CAWCD.
        /// </summary>
        public const string CAWCD = "CAWCD";

        /// <summary>
        /// CAWAB.
        /// </summary>
        public const string CAWAB = "CAWAB";

        /// <summary>
        /// CAWNUM.
        /// </summary>
        public const string CAWNUM = "CAWNUM";

        /// <summary>
        /// CAWMDT.
        /// </summary>
        public const string CAWMDT = "CAWMDT";

        /// <summary>
        /// CAUOM.
        /// </summary>
        public const string CAUOM = "CAUOM";
    }

    /// <inheritdoc />
    public override string TableName => "F31B053";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CAMCU", "CAMCU", JdeDataType.String, 24),
        new JdeField("CAWOPID", "CAWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("CAEQPID", "CAEQPID", JdeDataType.Numeric),
        new JdeField("CAITM", "CAITM", JdeDataType.Numeric),
        new JdeField("CAWCALN", "CAWCALN", JdeDataType.Numeric, null, true, true),
        new JdeField("CAUSGRATE", "CAUSGRATE", JdeDataType.String, 30),
        new JdeField("CAECQTY", "CAECQTY", JdeDataType.Numeric),
        new JdeField("CAUOM1", "CAUOM1", JdeDataType.String, 4),
        new JdeField("CALOCN", "CALOCN", JdeDataType.String, 40),
        new JdeField("CALOTN", "CALOTN", JdeDataType.String, 60),
        new JdeField("CAURAB", "CAURAB", JdeDataType.Numeric),
        new JdeField("CAURAT", "CAURAT", JdeDataType.Numeric),
        new JdeField("CAURCD", "CAURCD", JdeDataType.String, 4),
        new JdeField("CAURDT", "CAURDT", JdeDataType.Numeric),
        new JdeField("CAURRF", "CAURRF", JdeDataType.String, 30),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CAUPMJ", "CAUPMJ", JdeDataType.Numeric),
        new JdeField("CAUPMT", "CAUPMT", JdeDataType.Numeric),
        new JdeField("CAJOBN", "CAJOBN", JdeDataType.String, 20),
        new JdeField("CAMKEY", "CAMKEY", JdeDataType.String, 30),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CAQTST", "CAQTST", JdeDataType.String, 50),
        new JdeField("CAWRF", "CAWRF", JdeDataType.String, 60),
        new JdeField("CAWCD", "CAWCD", JdeDataType.String, 6),
        new JdeField("CAWAB", "CAWAB", JdeDataType.Numeric),
        new JdeField("CAWNUM", "CAWNUM", JdeDataType.Numeric),
        new JdeField("CAWMDT", "CAWMDT", JdeDataType.Numeric),
        new JdeField("CAUOM", "CAUOM", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B053_0", "Primary Key on CAWOPID, CAWCALN", new[] { "CAWOPID", "CAWCALN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B053_2", "Index on CAMCU, CAWOPID, CAEQPID, CAITM, CAWCALN", new[] { "CAMCU", "CAWOPID", "CAEQPID", "CAITM", "CAWCALN" }),
        new JdeIndex("F31B053_3", "Index on CAMCU, CAWOPID, CAEQPID, CAITM", new[] { "CAMCU", "CAWOPID", "CAEQPID", "CAITM" }),
        new JdeIndex("F31B053_4", "Index on CAMCU, CAWOPID, CAEQPID", new[] { "CAMCU", "CAWOPID", "CAEQPID" }),
        new JdeIndex("F31B053_5", "Index on CAWOPID, CAITM, CALOTN", new[] { "CAWOPID", "CAITM", "CALOTN" })
    };
}
