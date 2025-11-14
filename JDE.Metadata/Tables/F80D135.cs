using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D135 - .
/// </summary>
public class F80D135 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SMALERT.
        /// </summary>
        public const string SMALERT = "SMALERT";

        /// <summary>
        /// SMPRCSID.
        /// </summary>
        public const string SMPRCSID = "SMPRCSID";

        /// <summary>
        /// SMURCD.
        /// </summary>
        public const string SMURCD = "SMURCD";

        /// <summary>
        /// SMURDT.
        /// </summary>
        public const string SMURDT = "SMURDT";

        /// <summary>
        /// SMURAT.
        /// </summary>
        public const string SMURAT = "SMURAT";

        /// <summary>
        /// SMURAB.
        /// </summary>
        public const string SMURAB = "SMURAB";

        /// <summary>
        /// SMURRF.
        /// </summary>
        public const string SMURRF = "SMURRF";

        /// <summary>
        /// SMUSER.
        /// </summary>
        public const string SMUSER = "SMUSER";

        /// <summary>
        /// SMMKEY.
        /// </summary>
        public const string SMMKEY = "SMMKEY";

        /// <summary>
        /// SMPID.
        /// </summary>
        public const string SMPID = "SMPID";

        /// <summary>
        /// SMUUPMJ.
        /// </summary>
        public const string SMUUPMJ = "SMUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D135";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SMALERT", "SMALERT", JdeDataType.Numeric, null, true, true),
        new JdeField("SMPRCSID", "SMPRCSID", JdeDataType.String, 40, true, true),
        new JdeField("SMURCD", "SMURCD", JdeDataType.String, 4),
        new JdeField("SMURDT", "SMURDT", JdeDataType.Numeric),
        new JdeField("SMURAT", "SMURAT", JdeDataType.Numeric),
        new JdeField("SMURAB", "SMURAB", JdeDataType.Numeric),
        new JdeField("SMURRF", "SMURRF", JdeDataType.String, 30),
        new JdeField("SMUSER", "SMUSER", JdeDataType.String, 20),
        new JdeField("SMMKEY", "SMMKEY", JdeDataType.String, 30),
        new JdeField("SMPID", "SMPID", JdeDataType.String, 20),
        new JdeField("SMUUPMJ", "SMUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D135_0", "Primary Key on SMALERT, SMPRCSID", new[] { "SMALERT", "SMPRCSID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F80D135_2", "Index on SMPRCSID", new[] { "SMPRCSID" })
    };
}
