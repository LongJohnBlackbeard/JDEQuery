using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79ADC - .
/// </summary>
public class F79ADC : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DC79AGUID.
        /// </summary>
        public const string DC79AGUID = "DC79AGUID";

        /// <summary>
        /// DC79ART.
        /// </summary>
        public const string DC79ART = "DC79ART";

        /// <summary>
        /// DC79AKYD.
        /// </summary>
        public const string DC79AKYD = "DC79AKYD";

        /// <summary>
        /// DCPID.
        /// </summary>
        public const string DCPID = "DCPID";

        /// <summary>
        /// DCUSER.
        /// </summary>
        public const string DCUSER = "DCUSER";

        /// <summary>
        /// DCJOBN.
        /// </summary>
        public const string DCJOBN = "DCJOBN";

        /// <summary>
        /// DCUPMJ.
        /// </summary>
        public const string DCUPMJ = "DCUPMJ";

        /// <summary>
        /// DCTDAY.
        /// </summary>
        public const string DCTDAY = "DCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F79ADC";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DC79AGUID", "DC79AGUID", JdeDataType.Numeric, null, true, true),
        new JdeField("DC79ART", "DC79ART", JdeDataType.String, 20),
        new JdeField("DC79AKYD", "DC79AKYD", JdeDataType.String, 200),
        new JdeField("DCPID", "DCPID", JdeDataType.String, 20),
        new JdeField("DCUSER", "DCUSER", JdeDataType.String, 20),
        new JdeField("DCJOBN", "DCJOBN", JdeDataType.String, 20),
        new JdeField("DCUPMJ", "DCUPMJ", JdeDataType.Numeric),
        new JdeField("DCTDAY", "DCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79ADC_0", "Primary Key on DC79AGUID", new[] { "DC79AGUID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79ADC_2", "Unique Index on DC79ART", new[] { "DC79ART" }, isUnique: true)
    };
}
