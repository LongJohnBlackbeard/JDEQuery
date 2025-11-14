using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M006 - .
/// </summary>
public class F76M006 : JdeTable
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
        /// WAM76WHTP.
        /// </summary>
        public const string WAM76WHTP = "WAM76WHTP";

        /// <summary>
        /// WAM76WCON.
        /// </summary>
        public const string WAM76WCON = "WAM76WCON";

        /// <summary>
        /// WAM76FSTR.
        /// </summary>
        public const string WAM76FSTR = "WAM76FSTR";

        /// <summary>
        /// WAM76FNUM.
        /// </summary>
        public const string WAM76FNUM = "WAM76FNUM";

        /// <summary>
        /// WAM76FFLG.
        /// </summary>
        public const string WAM76FFLG = "WAM76FFLG";

        /// <summary>
        /// WAM76FDAT.
        /// </summary>
        public const string WAM76FDAT = "WAM76FDAT";

        /// <summary>
        /// WAUSER.
        /// </summary>
        public const string WAUSER = "WAUSER";

        /// <summary>
        /// WAPID.
        /// </summary>
        public const string WAPID = "WAPID";

        /// <summary>
        /// WAJOBN.
        /// </summary>
        public const string WAJOBN = "WAJOBN";

        /// <summary>
        /// WAUPMJ.
        /// </summary>
        public const string WAUPMJ = "WAUPMJ";

        /// <summary>
        /// WAUPMT.
        /// </summary>
        public const string WAUPMT = "WAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76M006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WAAN8", "WAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("WAM76WHTP", "WAM76WHTP", JdeDataType.String, 2, true, true),
        new JdeField("WAM76WCON", "WAM76WCON", JdeDataType.String, 6),
        new JdeField("WAM76FSTR", "WAM76FSTR", JdeDataType.String, 60),
        new JdeField("WAM76FNUM", "WAM76FNUM", JdeDataType.Numeric),
        new JdeField("WAM76FFLG", "WAM76FFLG", JdeDataType.String, 2),
        new JdeField("WAM76FDAT", "WAM76FDAT", JdeDataType.Numeric),
        new JdeField("WAUSER", "WAUSER", JdeDataType.String, 20),
        new JdeField("WAPID", "WAPID", JdeDataType.String, 20),
        new JdeField("WAJOBN", "WAJOBN", JdeDataType.String, 20),
        new JdeField("WAUPMJ", "WAUPMJ", JdeDataType.Numeric),
        new JdeField("WAUPMT", "WAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M006_0", "Primary Key on WAAN8, WAM76WHTP", new[] { "WAAN8", "WAM76WHTP" }, isUnique: true, isPrimaryKey: true)
    };
}
