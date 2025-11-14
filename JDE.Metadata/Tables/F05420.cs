using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05420 - .
/// </summary>
public class F05420 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WAAN8.
        /// </summary>
        public const string WAAN8 = "WAAN8";

        /// <summary>
        /// WAPROCVER.
        /// </summary>
        public const string WAPROCVER = "WAPROCVER";

        /// <summary>
        /// WAPROCNAME.
        /// </summary>
        public const string WAPROCNAME = "WAPROCNAME";

        /// <summary>
        /// WAWFOBNM.
        /// </summary>
        public const string WAWFOBNM = "WAWFOBNM";

        /// <summary>
        /// WAESIGN.
        /// </summary>
        public const string WAESIGN = "WAESIGN";

        /// <summary>
        /// WAADAT.
        /// </summary>
        public const string WAADAT = "WAADAT";

        /// <summary>
        /// WAAPR.
        /// </summary>
        public const string WAAPR = "WAAPR";

        /// <summary>
        /// WAPID.
        /// </summary>
        public const string WAPID = "WAPID";

        /// <summary>
        /// WAUPMJ.
        /// </summary>
        public const string WAUPMJ = "WAUPMJ";

        /// <summary>
        /// WAUPMT.
        /// </summary>
        public const string WAUPMT = "WAUPMT";

        /// <summary>
        /// WAUSER.
        /// </summary>
        public const string WAUSER = "WAUSER";

        /// <summary>
        /// WAJOBN.
        /// </summary>
        public const string WAJOBN = "WAJOBN";

        /// <summary>
        /// WAEECD.
        /// </summary>
        public const string WAEECD = "WAEECD";

        /// <summary>
        /// WAPROCIST.
        /// </summary>
        public const string WAPROCIST = "WAPROCIST";

        /// <summary>
        /// WAEVET.
        /// </summary>
        public const string WAEVET = "WAEVET";
    }

    /// <inheritdoc />
    public override string TableName => "F05420";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WAAN8", "WAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("WAPROCVER", "WAPROCVER", JdeDataType.Numeric),
        new JdeField("WAPROCNAME", "WAPROCNAME", JdeDataType.String, 20),
        new JdeField("WAWFOBNM", "WAWFOBNM", JdeDataType.String, 20, true, true),
        new JdeField("WAESIGN", "WAESIGN", JdeDataType.String, 32, true, true),
        new JdeField("WAADAT", "WAADAT", JdeDataType.Numeric),
        new JdeField("WAAPR", "WAAPR", JdeDataType.String, 2),
        new JdeField("WAPID", "WAPID", JdeDataType.String, 20),
        new JdeField("WAUPMJ", "WAUPMJ", JdeDataType.Numeric),
        new JdeField("WAUPMT", "WAUPMT", JdeDataType.Numeric),
        new JdeField("WAUSER", "WAUSER", JdeDataType.String, 20),
        new JdeField("WAJOBN", "WAJOBN", JdeDataType.String, 20),
        new JdeField("WAEECD", "WAEECD", JdeDataType.String, 6, true, true),
        new JdeField("WAPROCIST", "WAPROCIST", JdeDataType.Numeric),
        new JdeField("WAEVET", "WAEVET", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05420_0", "Primary Key on WAAN8, WAEVET, WAWFOBNM, WAEECD, WAESIGN", new[] { "WAAN8", "WAEVET", "WAWFOBNM", "WAEECD", "WAESIGN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05420_2", "Index on WAAN8, WAWFOBNM, WAESIGN", new[] { "WAAN8", "WAWFOBNM", "WAESIGN" })
    };
}
