using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J71 - .
/// </summary>
public class F09J71 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BHMCU.
        /// </summary>
        public const string BHMCU = "BHMCU";

        /// <summary>
        /// BHJVBUSTS.
        /// </summary>
        public const string BHJVBUSTS = "BHJVBUSTS";

        /// <summary>
        /// BHEFTB.
        /// </summary>
        public const string BHEFTB = "BHEFTB";

        /// <summary>
        /// BHUSER.
        /// </summary>
        public const string BHUSER = "BHUSER";

        /// <summary>
        /// BHUPMJ.
        /// </summary>
        public const string BHUPMJ = "BHUPMJ";

        /// <summary>
        /// BHUPMT.
        /// </summary>
        public const string BHUPMT = "BHUPMT";

        /// <summary>
        /// BHPID.
        /// </summary>
        public const string BHPID = "BHPID";

        /// <summary>
        /// BHMKEY.
        /// </summary>
        public const string BHMKEY = "BHMKEY";

        /// <summary>
        /// BHURRFJC01.
        /// </summary>
        public const string BHURRFJC01 = "BHURRFJC01";

        /// <summary>
        /// BHURRFJC02.
        /// </summary>
        public const string BHURRFJC02 = "BHURRFJC02";

        /// <summary>
        /// BHURRFJC03.
        /// </summary>
        public const string BHURRFJC03 = "BHURRFJC03";

        /// <summary>
        /// BHURRFJC04.
        /// </summary>
        public const string BHURRFJC04 = "BHURRFJC04";

        /// <summary>
        /// BHURRFJC05.
        /// </summary>
        public const string BHURRFJC05 = "BHURRFJC05";

        /// <summary>
        /// BHURDTJC01.
        /// </summary>
        public const string BHURDTJC01 = "BHURDTJC01";

        /// <summary>
        /// BHURDTJC02.
        /// </summary>
        public const string BHURDTJC02 = "BHURDTJC02";

        /// <summary>
        /// BHURDTJC03.
        /// </summary>
        public const string BHURDTJC03 = "BHURDTJC03";

        /// <summary>
        /// BHURDTJC04.
        /// </summary>
        public const string BHURDTJC04 = "BHURDTJC04";

        /// <summary>
        /// BHURDTJC05.
        /// </summary>
        public const string BHURDTJC05 = "BHURDTJC05";

        /// <summary>
        /// BHURSTJC01.
        /// </summary>
        public const string BHURSTJC01 = "BHURSTJC01";

        /// <summary>
        /// BHURSTJC02.
        /// </summary>
        public const string BHURSTJC02 = "BHURSTJC02";

        /// <summary>
        /// BHURSTJC03.
        /// </summary>
        public const string BHURSTJC03 = "BHURSTJC03";

        /// <summary>
        /// BHURSTJC04.
        /// </summary>
        public const string BHURSTJC04 = "BHURSTJC04";

        /// <summary>
        /// BHURSTJC05.
        /// </summary>
        public const string BHURSTJC05 = "BHURSTJC05";

        /// <summary>
        /// BHURNUJC01.
        /// </summary>
        public const string BHURNUJC01 = "BHURNUJC01";

        /// <summary>
        /// BHURNUJC02.
        /// </summary>
        public const string BHURNUJC02 = "BHURNUJC02";

        /// <summary>
        /// BHURNUJC03.
        /// </summary>
        public const string BHURNUJC03 = "BHURNUJC03";

        /// <summary>
        /// BHURNUJC04.
        /// </summary>
        public const string BHURNUJC04 = "BHURNUJC04";

        /// <summary>
        /// BHURNUJC05.
        /// </summary>
        public const string BHURNUJC05 = "BHURNUJC05";

        /// <summary>
        /// BHURCDJC01.
        /// </summary>
        public const string BHURCDJC01 = "BHURCDJC01";

        /// <summary>
        /// BHURCDJC02.
        /// </summary>
        public const string BHURCDJC02 = "BHURCDJC02";

        /// <summary>
        /// BHURCDJC03.
        /// </summary>
        public const string BHURCDJC03 = "BHURCDJC03";

        /// <summary>
        /// BHURCDJC04.
        /// </summary>
        public const string BHURCDJC04 = "BHURCDJC04";

        /// <summary>
        /// BHURCDJC05.
        /// </summary>
        public const string BHURCDJC05 = "BHURCDJC05";

        /// <summary>
        /// BHURATJC01.
        /// </summary>
        public const string BHURATJC01 = "BHURATJC01";

        /// <summary>
        /// BHURATJC02.
        /// </summary>
        public const string BHURATJC02 = "BHURATJC02";

        /// <summary>
        /// BHURATJC03.
        /// </summary>
        public const string BHURATJC03 = "BHURATJC03";

        /// <summary>
        /// BHURATJC04.
        /// </summary>
        public const string BHURATJC04 = "BHURATJC04";

        /// <summary>
        /// BHURATJC05.
        /// </summary>
        public const string BHURATJC05 = "BHURATJC05";

        /// <summary>
        /// BHJVJBCH1.
        /// </summary>
        public const string BHJVJBCH1 = "BHJVJBCH1";

        /// <summary>
        /// BHJVJBCH2.
        /// </summary>
        public const string BHJVJBCH2 = "BHJVJBCH2";

        /// <summary>
        /// BHJVJBCH3.
        /// </summary>
        public const string BHJVJBCH3 = "BHJVJBCH3";

        /// <summary>
        /// BHJVJBST1.
        /// </summary>
        public const string BHJVJBST1 = "BHJVJBST1";

        /// <summary>
        /// BHJVJBST2.
        /// </summary>
        public const string BHJVJBST2 = "BHJVJBST2";

        /// <summary>
        /// BHJVJBST3.
        /// </summary>
        public const string BHJVJBST3 = "BHJVJBST3";

        /// <summary>
        /// BHJVJBDT1.
        /// </summary>
        public const string BHJVJBDT1 = "BHJVJBDT1";

        /// <summary>
        /// BHJVJBDT2.
        /// </summary>
        public const string BHJVJBDT2 = "BHJVJBDT2";

        /// <summary>
        /// BHJVJBDT3.
        /// </summary>
        public const string BHJVJBDT3 = "BHJVJBDT3";

        /// <summary>
        /// BHJVJBNU1.
        /// </summary>
        public const string BHJVJBNU1 = "BHJVJBNU1";

        /// <summary>
        /// BHJVJBNU2.
        /// </summary>
        public const string BHJVJBNU2 = "BHJVJBNU2";

        /// <summary>
        /// BHJVJBNU3.
        /// </summary>
        public const string BHJVJBNU3 = "BHJVJBNU3";
    }

    /// <inheritdoc />
    public override string TableName => "F09J71";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BHMCU", "BHMCU", JdeDataType.String, 24, true, true),
        new JdeField("BHJVBUSTS", "BHJVBUSTS", JdeDataType.String, 6, true, true),
        new JdeField("BHEFTB", "BHEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("BHUSER", "BHUSER", JdeDataType.String, 20),
        new JdeField("BHUPMJ", "BHUPMJ", JdeDataType.Numeric),
        new JdeField("BHUPMT", "BHUPMT", JdeDataType.Numeric),
        new JdeField("BHPID", "BHPID", JdeDataType.String, 20),
        new JdeField("BHMKEY", "BHMKEY", JdeDataType.String, 30),
        new JdeField("BHURRFJC01", "BHURRFJC01", JdeDataType.String, 30),
        new JdeField("BHURRFJC02", "BHURRFJC02", JdeDataType.String, 30),
        new JdeField("BHURRFJC03", "BHURRFJC03", JdeDataType.String, 30),
        new JdeField("BHURRFJC04", "BHURRFJC04", JdeDataType.String, 30),
        new JdeField("BHURRFJC05", "BHURRFJC05", JdeDataType.String, 30),
        new JdeField("BHURDTJC01", "BHURDTJC01", JdeDataType.Numeric),
        new JdeField("BHURDTJC02", "BHURDTJC02", JdeDataType.Numeric),
        new JdeField("BHURDTJC03", "BHURDTJC03", JdeDataType.Numeric),
        new JdeField("BHURDTJC04", "BHURDTJC04", JdeDataType.Numeric),
        new JdeField("BHURDTJC05", "BHURDTJC05", JdeDataType.Numeric),
        new JdeField("BHURSTJC01", "BHURSTJC01", JdeDataType.String, 160),
        new JdeField("BHURSTJC02", "BHURSTJC02", JdeDataType.String, 160),
        new JdeField("BHURSTJC03", "BHURSTJC03", JdeDataType.String, 160),
        new JdeField("BHURSTJC04", "BHURSTJC04", JdeDataType.String, 160),
        new JdeField("BHURSTJC05", "BHURSTJC05", JdeDataType.String, 160),
        new JdeField("BHURNUJC01", "BHURNUJC01", JdeDataType.Numeric),
        new JdeField("BHURNUJC02", "BHURNUJC02", JdeDataType.Numeric),
        new JdeField("BHURNUJC03", "BHURNUJC03", JdeDataType.Numeric),
        new JdeField("BHURNUJC04", "BHURNUJC04", JdeDataType.Numeric),
        new JdeField("BHURNUJC05", "BHURNUJC05", JdeDataType.Numeric),
        new JdeField("BHURCDJC01", "BHURCDJC01", JdeDataType.String, 4),
        new JdeField("BHURCDJC02", "BHURCDJC02", JdeDataType.String, 4),
        new JdeField("BHURCDJC03", "BHURCDJC03", JdeDataType.String, 4),
        new JdeField("BHURCDJC04", "BHURCDJC04", JdeDataType.String, 4),
        new JdeField("BHURCDJC05", "BHURCDJC05", JdeDataType.String, 4),
        new JdeField("BHURATJC01", "BHURATJC01", JdeDataType.Numeric),
        new JdeField("BHURATJC02", "BHURATJC02", JdeDataType.Numeric),
        new JdeField("BHURATJC03", "BHURATJC03", JdeDataType.Numeric),
        new JdeField("BHURATJC04", "BHURATJC04", JdeDataType.Numeric),
        new JdeField("BHURATJC05", "BHURATJC05", JdeDataType.Numeric),
        new JdeField("BHJVJBCH1", "BHJVJBCH1", JdeDataType.String, 2),
        new JdeField("BHJVJBCH2", "BHJVJBCH2", JdeDataType.String, 2),
        new JdeField("BHJVJBCH3", "BHJVJBCH3", JdeDataType.String, 2),
        new JdeField("BHJVJBST1", "BHJVJBST1", JdeDataType.String, 160),
        new JdeField("BHJVJBST2", "BHJVJBST2", JdeDataType.String, 160),
        new JdeField("BHJVJBST3", "BHJVJBST3", JdeDataType.String, 160),
        new JdeField("BHJVJBDT1", "BHJVJBDT1", JdeDataType.Numeric),
        new JdeField("BHJVJBDT2", "BHJVJBDT2", JdeDataType.Numeric),
        new JdeField("BHJVJBDT3", "BHJVJBDT3", JdeDataType.Numeric),
        new JdeField("BHJVJBNU1", "BHJVJBNU1", JdeDataType.Numeric),
        new JdeField("BHJVJBNU2", "BHJVJBNU2", JdeDataType.Numeric),
        new JdeField("BHJVJBNU3", "BHJVJBNU3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J71_0", "Primary Key on BHMCU, BHJVBUSTS, BHEFTB", new[] { "BHMCU", "BHJVBUSTS", "BHEFTB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J71_3", "Index on BHMCU, SYS_NC00051$", new[] { "BHMCU", "SYS_NC00051$" }),
        new JdeIndex("F09J71_4", "Index on BHMCU", new[] { "BHMCU" }),
        new JdeIndex("F09J71_5", "Index on BHMCU, BHEFTB", new[] { "BHMCU", "BHEFTB" })
    };
}
