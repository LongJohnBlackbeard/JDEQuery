using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A671 - .
/// </summary>
public class F75A671 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LAAN8.
        /// </summary>
        public const string LAAN8 = "LAAN8";

        /// <summary>
        /// LAPDBA.
        /// </summary>
        public const string LAPDBA = "LAPDBA";

        /// <summary>
        /// LALNID.
        /// </summary>
        public const string LALNID = "LALNID";

        /// <summary>
        /// LALSCR.
        /// </summary>
        public const string LALSCR = "LALSCR";

        /// <summary>
        /// LALSLD.
        /// </summary>
        public const string LALSLD = "LALSLD";

        /// <summary>
        /// LALSLP.
        /// </summary>
        public const string LALSLP = "LALSLP";

        /// <summary>
        /// LAAVLG.
        /// </summary>
        public const string LAAVLG = "LAAVLG";

        /// <summary>
        /// LAAVLH.
        /// </summary>
        public const string LAAVLH = "LAAVLH";

        /// <summary>
        /// LALCMM.
        /// </summary>
        public const string LALCMM = "LALCMM";

        /// <summary>
        /// LAEEXX.
        /// </summary>
        public const string LAEEXX = "LAEEXX";

        /// <summary>
        /// LAUPMJ.
        /// </summary>
        public const string LAUPMJ = "LAUPMJ";

        /// <summary>
        /// LAUPMT.
        /// </summary>
        public const string LAUPMT = "LAUPMT";

        /// <summary>
        /// LAPID.
        /// </summary>
        public const string LAPID = "LAPID";

        /// <summary>
        /// LAJOBN.
        /// </summary>
        public const string LAJOBN = "LAJOBN";

        /// <summary>
        /// LAUSER.
        /// </summary>
        public const string LAUSER = "LAUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F75A671";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LAAN8", "LAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LAPDBA", "LAPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("LALNID", "LALNID", JdeDataType.Numeric, null, true, true),
        new JdeField("LALSCR", "LALSCR", JdeDataType.String, 2),
        new JdeField("LALSLD", "LALSLD", JdeDataType.Numeric),
        new JdeField("LALSLP", "LALSLP", JdeDataType.Numeric),
        new JdeField("LAAVLG", "LAAVLG", JdeDataType.Numeric),
        new JdeField("LAAVLH", "LAAVLH", JdeDataType.Numeric),
        new JdeField("LALCMM", "LALCMM", JdeDataType.String, 600),
        new JdeField("LAEEXX", "LAEEXX", JdeDataType.String, 4),
        new JdeField("LAUPMJ", "LAUPMJ", JdeDataType.Numeric),
        new JdeField("LAUPMT", "LAUPMT", JdeDataType.Numeric),
        new JdeField("LAPID", "LAPID", JdeDataType.String, 20),
        new JdeField("LAJOBN", "LAJOBN", JdeDataType.String, 20),
        new JdeField("LAUSER", "LAUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A671_0", "Primary Key on LAAN8, LAPDBA, LALNID", new[] { "LAAN8", "LAPDBA", "LALNID" }, isUnique: true, isPrimaryKey: true)
    };
}
