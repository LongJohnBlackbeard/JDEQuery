using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79ADV - .
/// </summary>
public class F79ADV : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DV79AGUID.
        /// </summary>
        public const string DV79AGUID = "DV79AGUID";

        /// <summary>
        /// DV79ART.
        /// </summary>
        public const string DV79ART = "DV79ART";

        /// <summary>
        /// DV79AKY.
        /// </summary>
        public const string DV79AKY = "DV79AKY";

        /// <summary>
        /// DV79AKYD.
        /// </summary>
        public const string DV79AKYD = "DV79AKYD";

        /// <summary>
        /// DV79AKYC.
        /// </summary>
        public const string DV79AKYC = "DV79AKYC";

        /// <summary>
        /// DVPID.
        /// </summary>
        public const string DVPID = "DVPID";

        /// <summary>
        /// DVUSER.
        /// </summary>
        public const string DVUSER = "DVUSER";

        /// <summary>
        /// DVJOBN.
        /// </summary>
        public const string DVJOBN = "DVJOBN";

        /// <summary>
        /// DVUPMJ.
        /// </summary>
        public const string DVUPMJ = "DVUPMJ";

        /// <summary>
        /// DVTDAY.
        /// </summary>
        public const string DVTDAY = "DVTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F79ADV";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DV79AGUID", "DV79AGUID", JdeDataType.Numeric, null, true, true),
        new JdeField("DV79ART", "DV79ART", JdeDataType.String, 20),
        new JdeField("DV79AKY", "DV79AKY", JdeDataType.String, 30, true, true),
        new JdeField("DV79AKYD", "DV79AKYD", JdeDataType.String, 200),
        new JdeField("DV79AKYC", "DV79AKYC", JdeDataType.String, 200),
        new JdeField("DVPID", "DVPID", JdeDataType.String, 20),
        new JdeField("DVUSER", "DVUSER", JdeDataType.String, 20),
        new JdeField("DVJOBN", "DVJOBN", JdeDataType.String, 20),
        new JdeField("DVUPMJ", "DVUPMJ", JdeDataType.Numeric),
        new JdeField("DVTDAY", "DVTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79ADV_0", "Primary Key on DV79AGUID, DV79AKY", new[] { "DV79AGUID", "DV79AKY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79ADV_2", "Index on DV79ART, DV79AKY", new[] { "DV79ART", "DV79AKY" })
    };
}
