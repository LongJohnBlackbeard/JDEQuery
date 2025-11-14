using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B052 - .
/// </summary>
public class F31B052 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EAMCU.
        /// </summary>
        public const string EAMCU = "EAMCU";

        /// <summary>
        /// EAWOPID.
        /// </summary>
        public const string EAWOPID = "EAWOPID";

        /// <summary>
        /// EAEQPID.
        /// </summary>
        public const string EAEQPID = "EAEQPID";

        /// <summary>
        /// EAWEALN.
        /// </summary>
        public const string EAWEALN = "EAWEALN";

        /// <summary>
        /// EAEQPPT.
        /// </summary>
        public const string EAEQPPT = "EAEQPPT";

        /// <summary>
        /// EAURAB.
        /// </summary>
        public const string EAURAB = "EAURAB";

        /// <summary>
        /// EAURAT.
        /// </summary>
        public const string EAURAT = "EAURAT";

        /// <summary>
        /// EAURCD.
        /// </summary>
        public const string EAURCD = "EAURCD";

        /// <summary>
        /// EAURDT.
        /// </summary>
        public const string EAURDT = "EAURDT";

        /// <summary>
        /// EAURRF.
        /// </summary>
        public const string EAURRF = "EAURRF";

        /// <summary>
        /// EAUSER.
        /// </summary>
        public const string EAUSER = "EAUSER";

        /// <summary>
        /// EAUPMJ.
        /// </summary>
        public const string EAUPMJ = "EAUPMJ";

        /// <summary>
        /// EAUPMT.
        /// </summary>
        public const string EAUPMT = "EAUPMT";

        /// <summary>
        /// EAJOBN.
        /// </summary>
        public const string EAJOBN = "EAJOBN";

        /// <summary>
        /// EAMKEY.
        /// </summary>
        public const string EAMKEY = "EAMKEY";

        /// <summary>
        /// EAPID.
        /// </summary>
        public const string EAPID = "EAPID";

        /// <summary>
        /// EAQTST.
        /// </summary>
        public const string EAQTST = "EAQTST";

        /// <summary>
        /// EAWRF.
        /// </summary>
        public const string EAWRF = "EAWRF";

        /// <summary>
        /// EAWCD.
        /// </summary>
        public const string EAWCD = "EAWCD";

        /// <summary>
        /// EAWAB.
        /// </summary>
        public const string EAWAB = "EAWAB";

        /// <summary>
        /// EAWNUM.
        /// </summary>
        public const string EAWNUM = "EAWNUM";

        /// <summary>
        /// EAWMDT.
        /// </summary>
        public const string EAWMDT = "EAWMDT";

        /// <summary>
        /// EAUOM.
        /// </summary>
        public const string EAUOM = "EAUOM";

        /// <summary>
        /// EAWACTIME.
        /// </summary>
        public const string EAWACTIME = "EAWACTIME";

        /// <summary>
        /// EAWTUOM.
        /// </summary>
        public const string EAWTUOM = "EAWTUOM";
    }

    /// <inheritdoc />
    public override string TableName => "F31B052";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EAMCU", "EAMCU", JdeDataType.String, 24),
        new JdeField("EAWOPID", "EAWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("EAEQPID", "EAEQPID", JdeDataType.Numeric),
        new JdeField("EAWEALN", "EAWEALN", JdeDataType.Numeric, null, true, true),
        new JdeField("EAEQPPT", "EAEQPPT", JdeDataType.String, 120),
        new JdeField("EAURAB", "EAURAB", JdeDataType.Numeric),
        new JdeField("EAURAT", "EAURAT", JdeDataType.Numeric),
        new JdeField("EAURCD", "EAURCD", JdeDataType.String, 4),
        new JdeField("EAURDT", "EAURDT", JdeDataType.Numeric),
        new JdeField("EAURRF", "EAURRF", JdeDataType.String, 30),
        new JdeField("EAUSER", "EAUSER", JdeDataType.String, 20),
        new JdeField("EAUPMJ", "EAUPMJ", JdeDataType.Numeric),
        new JdeField("EAUPMT", "EAUPMT", JdeDataType.Numeric),
        new JdeField("EAJOBN", "EAJOBN", JdeDataType.String, 20),
        new JdeField("EAMKEY", "EAMKEY", JdeDataType.String, 30),
        new JdeField("EAPID", "EAPID", JdeDataType.String, 20),
        new JdeField("EAQTST", "EAQTST", JdeDataType.String, 50),
        new JdeField("EAWRF", "EAWRF", JdeDataType.String, 60),
        new JdeField("EAWCD", "EAWCD", JdeDataType.String, 6),
        new JdeField("EAWAB", "EAWAB", JdeDataType.Numeric),
        new JdeField("EAWNUM", "EAWNUM", JdeDataType.Numeric),
        new JdeField("EAWMDT", "EAWMDT", JdeDataType.Numeric),
        new JdeField("EAUOM", "EAUOM", JdeDataType.String, 4),
        new JdeField("EAWACTIME", "EAWACTIME", JdeDataType.Numeric),
        new JdeField("EAWTUOM", "EAWTUOM", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B052_0", "Primary Key on EAWOPID, EAWEALN", new[] { "EAWOPID", "EAWEALN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B052_2", "Index on EAMCU, EAWOPID, EAEQPID, EAWEALN", new[] { "EAMCU", "EAWOPID", "EAEQPID", "EAWEALN" }),
        new JdeIndex("F31B052_3", "Index on EAMCU, EAWOPID, EAEQPID", new[] { "EAMCU", "EAWOPID", "EAEQPID" }),
        new JdeIndex("F31B052_4", "Index on EAMCU, EAWOPID", new[] { "EAMCU", "EAWOPID" })
    };
}
