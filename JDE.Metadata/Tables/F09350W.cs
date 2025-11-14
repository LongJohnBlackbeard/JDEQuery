using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09350W - .
/// </summary>
public class F09350W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RWRUNID.
        /// </summary>
        public const string RWRUNID = "RWRUNID";

        /// <summary>
        /// RWLINN.
        /// </summary>
        public const string RWLINN = "RWLINN";

        /// <summary>
        /// RWGRPV1.
        /// </summary>
        public const string RWGRPV1 = "RWGRPV1";

        /// <summary>
        /// RWGRPV2.
        /// </summary>
        public const string RWGRPV2 = "RWGRPV2";

        /// <summary>
        /// RWGRPV3.
        /// </summary>
        public const string RWGRPV3 = "RWGRPV3";

        /// <summary>
        /// RWGRPV4.
        /// </summary>
        public const string RWGRPV4 = "RWGRPV4";

        /// <summary>
        /// RWGRPV5.
        /// </summary>
        public const string RWGRPV5 = "RWGRPV5";

        /// <summary>
        /// RWGRPV6.
        /// </summary>
        public const string RWGRPV6 = "RWGRPV6";

        /// <summary>
        /// RWGRPV7.
        /// </summary>
        public const string RWGRPV7 = "RWGRPV7";

        /// <summary>
        /// RWGRPV8.
        /// </summary>
        public const string RWGRPV8 = "RWGRPV8";

        /// <summary>
        /// RWGRPV9.
        /// </summary>
        public const string RWGRPV9 = "RWGRPV9";

        /// <summary>
        /// RWGRPV10.
        /// </summary>
        public const string RWGRPV10 = "RWGRPV10";

        /// <summary>
        /// RWCO.
        /// </summary>
        public const string RWCO = "RWCO";

        /// <summary>
        /// RWMCU.
        /// </summary>
        public const string RWMCU = "RWMCU";

        /// <summary>
        /// RWOBJ.
        /// </summary>
        public const string RWOBJ = "RWOBJ";

        /// <summary>
        /// RWSUB.
        /// </summary>
        public const string RWSUB = "RWSUB";

        /// <summary>
        /// RWLDA.
        /// </summary>
        public const string RWLDA = "RWLDA";

        /// <summary>
        /// RWPEC.
        /// </summary>
        public const string RWPEC = "RWPEC";

        /// <summary>
        /// RWAID.
        /// </summary>
        public const string RWAID = "RWAID";

        /// <summary>
        /// RWACCDESC.
        /// </summary>
        public const string RWACCDESC = "RWACCDESC";

        /// <summary>
        /// RWBUDES.
        /// </summary>
        public const string RWBUDES = "RWBUDES";

        /// <summary>
        /// RWRSTN.
        /// </summary>
        public const string RWRSTN = "RWRSTN";

        /// <summary>
        /// RWRPRID.
        /// </summary>
        public const string RWRPRID = "RWRPRID";

        /// <summary>
        /// RWRIDDS.
        /// </summary>
        public const string RWRIDDS = "RWRIDDS";

        /// <summary>
        /// RWUSER.
        /// </summary>
        public const string RWUSER = "RWUSER";

        /// <summary>
        /// RWRPSTN.
        /// </summary>
        public const string RWRPSTN = "RWRPSTN";

        /// <summary>
        /// RWVERN.
        /// </summary>
        public const string RWVERN = "RWVERN";

        /// <summary>
        /// RWUPMJ.
        /// </summary>
        public const string RWUPMJ = "RWUPMJ";

        /// <summary>
        /// RWUPMT.
        /// </summary>
        public const string RWUPMT = "RWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09350W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RWRUNID", "RWRUNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RWLINN", "RWLINN", JdeDataType.Numeric, null, true, true),
        new JdeField("RWGRPV1", "RWGRPV1", JdeDataType.String, 60, true, true),
        new JdeField("RWGRPV2", "RWGRPV2", JdeDataType.String, 60, true, true),
        new JdeField("RWGRPV3", "RWGRPV3", JdeDataType.String, 60, true, true),
        new JdeField("RWGRPV4", "RWGRPV4", JdeDataType.String, 60, true, true),
        new JdeField("RWGRPV5", "RWGRPV5", JdeDataType.String, 60, true, true),
        new JdeField("RWGRPV6", "RWGRPV6", JdeDataType.String, 60, true, true),
        new JdeField("RWGRPV7", "RWGRPV7", JdeDataType.String, 60, true, true),
        new JdeField("RWGRPV8", "RWGRPV8", JdeDataType.String, 60, true, true),
        new JdeField("RWGRPV9", "RWGRPV9", JdeDataType.String, 60, true, true),
        new JdeField("RWGRPV10", "RWGRPV10", JdeDataType.String, 60, true, true),
        new JdeField("RWCO", "RWCO", JdeDataType.String, 10),
        new JdeField("RWMCU", "RWMCU", JdeDataType.String, 24),
        new JdeField("RWOBJ", "RWOBJ", JdeDataType.String, 12),
        new JdeField("RWSUB", "RWSUB", JdeDataType.String, 16),
        new JdeField("RWLDA", "RWLDA", JdeDataType.String, 2),
        new JdeField("RWPEC", "RWPEC", JdeDataType.String, 2),
        new JdeField("RWAID", "RWAID", JdeDataType.String, 16),
        new JdeField("RWACCDESC", "RWACCDESC", JdeDataType.String, 60),
        new JdeField("RWBUDES", "RWBUDES", JdeDataType.String, 60),
        new JdeField("RWRSTN", "RWRSTN", JdeDataType.String, 40),
        new JdeField("RWRPRID", "RWRPRID", JdeDataType.Numeric),
        new JdeField("RWRIDDS", "RWRIDDS", JdeDataType.String, 160),
        new JdeField("RWUSER", "RWUSER", JdeDataType.String, 20),
        new JdeField("RWRPSTN", "RWRPSTN", JdeDataType.String, 40),
        new JdeField("RWVERN", "RWVERN", JdeDataType.String, 40),
        new JdeField("RWUPMJ", "RWUPMJ", JdeDataType.Numeric),
        new JdeField("RWUPMT", "RWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09350W_0", "Primary Key on RWRUNID, RWLINN, RWGRPV1, RWGRPV2, RWGRPV3, RWGRPV4, RWGRPV5, RWGRPV6, RWGRPV7, RWGRPV8, RWGRPV9, RWGRPV10", new[] { "RWRUNID", "RWLINN", "RWGRPV1", "RWGRPV2", "RWGRPV3", "RWGRPV4", "RWGRPV5", "RWGRPV6", "RWGRPV7", "RWGRPV8", "RWGRPV9", "RWGRPV10" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09350W_2", "Index on RWUSER, RWRPSTN, RWVERN", new[] { "RWUSER", "RWRPSTN", "RWVERN" }),
        new JdeIndex("F09350W_3", "Index on RWRUNID, RWRPRID, RWLINN, RWGRPV1, RWGRPV2, RWGRPV3, RWGRPV4, RWGRPV5, RWGRPV6, RWGRPV7, RWGRPV8, RWGRPV9, RWGRPV10", new[] { "RWRUNID", "RWRPRID", "RWLINN", "RWGRPV1", "RWGRPV2", "RWGRPV3", "RWGRPV4", "RWGRPV5", "RWGRPV6", "RWGRPV7", "RWGRPV8", "RWGRPV9", "RWGRPV10" })
    };
}
