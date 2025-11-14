using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F410211 - .
/// </summary>
public class F410211 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCMCU.
        /// </summary>
        public const string PCMCU = "PCMCU";

        /// <summary>
        /// PCPRJM.
        /// </summary>
        public const string PCPRJM = "PCPRJM";

        /// <summary>
        /// PCDOCO.
        /// </summary>
        public const string PCDOCO = "PCDOCO";

        /// <summary>
        /// PCITM.
        /// </summary>
        public const string PCITM = "PCITM";

        /// <summary>
        /// PCLOCN.
        /// </summary>
        public const string PCLOCN = "PCLOCN";

        /// <summary>
        /// PCLOTN.
        /// </summary>
        public const string PCLOTN = "PCLOTN";

        /// <summary>
        /// PCPJCM.
        /// </summary>
        public const string PCPJCM = "PCPJCM";

        /// <summary>
        /// PCPJDM.
        /// </summary>
        public const string PCPJDM = "PCPJDM";
    }

    /// <inheritdoc />
    public override string TableName => "F410211";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCMCU", "PCMCU", JdeDataType.String, 24, true, true),
        new JdeField("PCPRJM", "PCPRJM", JdeDataType.Numeric, null, true, true),
        new JdeField("PCDOCO", "PCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PCITM", "PCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PCLOCN", "PCLOCN", JdeDataType.String, 40, true, true),
        new JdeField("PCLOTN", "PCLOTN", JdeDataType.String, 60, true, true),
        new JdeField("PCPJCM", "PCPJCM", JdeDataType.Numeric),
        new JdeField("PCPJDM", "PCPJDM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F410211_0", "Primary Key on PCMCU, PCPRJM, PCDOCO, PCITM, PCLOCN, PCLOTN", new[] { "PCMCU", "PCPRJM", "PCDOCO", "PCITM", "PCLOCN", "PCLOTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F410211_2", "Index on PCMCU, PCITM, PCLOCN, PCLOTN", new[] { "PCMCU", "PCITM", "PCLOCN", "PCLOTN" })
    };
}
