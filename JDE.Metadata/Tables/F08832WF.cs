using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08832WF - .
/// </summary>
public class F08832WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MMMNAME.
        /// </summary>
        public const string MMMNAME = "MMMNAME";

        /// <summary>
        /// MMRWTYP.
        /// </summary>
        public const string MMRWTYP = "MMRWTYP";

        /// <summary>
        /// MMMOWNR.
        /// </summary>
        public const string MMMOWNR = "MMMOWNR";

        /// <summary>
        /// MMMTYPC.
        /// </summary>
        public const string MMMTYPC = "MMMTYPC";

        /// <summary>
        /// MMMDL01.
        /// </summary>
        public const string MMMDL01 = "MMMDL01";

        /// <summary>
        /// MMUPMJ.
        /// </summary>
        public const string MMUPMJ = "MMUPMJ";

        /// <summary>
        /// MMUPMT.
        /// </summary>
        public const string MMUPMT = "MMUPMT";

        /// <summary>
        /// MMPID.
        /// </summary>
        public const string MMPID = "MMPID";

        /// <summary>
        /// MMJOBN.
        /// </summary>
        public const string MMJOBN = "MMJOBN";

        /// <summary>
        /// MMUSER.
        /// </summary>
        public const string MMUSER = "MMUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F08832WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MMMNAME", "MMMNAME", JdeDataType.String, 20, true, true),
        new JdeField("MMRWTYP", "MMRWTYP", JdeDataType.String, 2, true, true),
        new JdeField("MMMOWNR", "MMMOWNR", JdeDataType.Numeric, null, true, true),
        new JdeField("MMMTYPC", "MMMTYPC", JdeDataType.String, 2),
        new JdeField("MMMDL01", "MMMDL01", JdeDataType.String, 60),
        new JdeField("MMUPMJ", "MMUPMJ", JdeDataType.Numeric),
        new JdeField("MMUPMT", "MMUPMT", JdeDataType.Numeric),
        new JdeField("MMPID", "MMPID", JdeDataType.String, 20),
        new JdeField("MMJOBN", "MMJOBN", JdeDataType.String, 20),
        new JdeField("MMUSER", "MMUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08832WF_0", "Primary Key on MMMNAME, MMRWTYP, MMMOWNR", new[] { "MMMNAME", "MMRWTYP", "MMMOWNR" }, isUnique: true, isPrimaryKey: true)
    };
}
