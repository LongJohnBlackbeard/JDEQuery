using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4510 - .
/// </summary>
public class F4510 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PWUKID.
        /// </summary>
        public const string PWUKID = "PWUKID";

        /// <summary>
        /// PWFOCUSON.
        /// </summary>
        public const string PWFOCUSON = "PWFOCUSON";

        /// <summary>
        /// PWAN8.
        /// </summary>
        public const string PWAN8 = "PWAN8";

        /// <summary>
        /// PWCPGP.
        /// </summary>
        public const string PWCPGP = "PWCPGP";

        /// <summary>
        /// PWUITM.
        /// </summary>
        public const string PWUITM = "PWUITM";

        /// <summary>
        /// PWPRGR.
        /// </summary>
        public const string PWPRGR = "PWPRGR";

        /// <summary>
        /// PWAST.
        /// </summary>
        public const string PWAST = "PWAST";

        /// <summary>
        /// PWMCU.
        /// </summary>
        public const string PWMCU = "PWMCU";

        /// <summary>
        /// PWCO.
        /// </summary>
        public const string PWCO = "PWCO";

        /// <summary>
        /// PWJOBSTS.
        /// </summary>
        public const string PWJOBSTS = "PWJOBSTS";

        /// <summary>
        /// PWUPMJ.
        /// </summary>
        public const string PWUPMJ = "PWUPMJ";

        /// <summary>
        /// PWTDAY.
        /// </summary>
        public const string PWTDAY = "PWTDAY";

        /// <summary>
        /// PWASN.
        /// </summary>
        public const string PWASN = "PWASN";

        /// <summary>
        /// PWSDGR.
        /// </summary>
        public const string PWSDGR = "PWSDGR";

        /// <summary>
        /// PWJOBN.
        /// </summary>
        public const string PWJOBN = "PWJOBN";

        /// <summary>
        /// PWUSER.
        /// </summary>
        public const string PWUSER = "PWUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F4510";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PWUKID", "PWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PWFOCUSON", "PWFOCUSON", JdeDataType.String, 4),
        new JdeField("PWAN8", "PWAN8", JdeDataType.Numeric),
        new JdeField("PWCPGP", "PWCPGP", JdeDataType.String, 16),
        new JdeField("PWUITM", "PWUITM", JdeDataType.String, 52),
        new JdeField("PWPRGR", "PWPRGR", JdeDataType.String, 16),
        new JdeField("PWAST", "PWAST", JdeDataType.String, 16),
        new JdeField("PWMCU", "PWMCU", JdeDataType.String, 24),
        new JdeField("PWCO", "PWCO", JdeDataType.String, 10),
        new JdeField("PWJOBSTS", "PWJOBSTS", JdeDataType.String, 4),
        new JdeField("PWUPMJ", "PWUPMJ", JdeDataType.Numeric),
        new JdeField("PWTDAY", "PWTDAY", JdeDataType.Numeric),
        new JdeField("PWASN", "PWASN", JdeDataType.String, 16),
        new JdeField("PWSDGR", "PWSDGR", JdeDataType.String, 16),
        new JdeField("PWJOBN", "PWJOBN", JdeDataType.String, 20),
        new JdeField("PWUSER", "PWUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4510_0", "Primary Key on PWUKID", new[] { "PWUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4510_2", "Index on PWFOCUSON, PWAN8, PWCO", new[] { "PWFOCUSON", "PWAN8", "PWCO" }),
        new JdeIndex("F4510_3", "Index on PWFOCUSON, PWCPGP, PWCO", new[] { "PWFOCUSON", "PWCPGP", "PWCO" }),
        new JdeIndex("F4510_4", "Index on PWFOCUSON, PWUITM, PWMCU", new[] { "PWFOCUSON", "PWUITM", "PWMCU" }),
        new JdeIndex("F4510_5", "Index on PWFOCUSON, PWPRGR, PWMCU", new[] { "PWFOCUSON", "PWPRGR", "PWMCU" }),
        new JdeIndex("F4510_6", "Index on PWFOCUSON, PWAST", new[] { "PWFOCUSON", "PWAST" })
    };
}
