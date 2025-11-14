using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7606B - .
/// </summary>
public class F7606B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MIMCU.
        /// </summary>
        public const string MIMCU = "MIMCU";

        /// <summary>
        /// MIFCO.
        /// </summary>
        public const string MIFCO = "MIFCO";

        /// <summary>
        /// MIUSER.
        /// </summary>
        public const string MIUSER = "MIUSER";

        /// <summary>
        /// MIPID.
        /// </summary>
        public const string MIPID = "MIPID";

        /// <summary>
        /// MIJOBN.
        /// </summary>
        public const string MIJOBN = "MIJOBN";

        /// <summary>
        /// MIUPMJ.
        /// </summary>
        public const string MIUPMJ = "MIUPMJ";

        /// <summary>
        /// MITDAY.
        /// </summary>
        public const string MITDAY = "MITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F7606B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MIMCU", "MIMCU", JdeDataType.String, 24, true, true),
        new JdeField("MIFCO", "MIFCO", JdeDataType.String, 10),
        new JdeField("MIUSER", "MIUSER", JdeDataType.String, 20),
        new JdeField("MIPID", "MIPID", JdeDataType.String, 20),
        new JdeField("MIJOBN", "MIJOBN", JdeDataType.String, 20),
        new JdeField("MIUPMJ", "MIUPMJ", JdeDataType.Numeric),
        new JdeField("MITDAY", "MITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7606B_0", "Primary Key on MIMCU", new[] { "MIMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
