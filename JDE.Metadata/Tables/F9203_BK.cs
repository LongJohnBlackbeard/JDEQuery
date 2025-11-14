using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F9203_BK - .
/// </summary>
public class F9203_BK : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FRDTAI.
        /// </summary>
        public const string FRDTAI = "FRDTAI";

        /// <summary>
        /// FRLNGP.
        /// </summary>
        public const string FRLNGP = "FRLNGP";

        /// <summary>
        /// FRSYR.
        /// </summary>
        public const string FRSYR = "FRSYR";

        /// <summary>
        /// FRDSCA.
        /// </summary>
        public const string FRDSCA = "FRDSCA";

        /// <summary>
        /// FRDSCC.
        /// </summary>
        public const string FRDSCC = "FRDSCC";

        /// <summary>
        /// FRSCRN.
        /// </summary>
        public const string FRSCRN = "FRSCRN";
    }

    /// <inheritdoc />
    public override string TableName => "F9203_BK";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FRDTAI", "FRDTAI", JdeDataType.String, 20),
        new JdeField("FRLNGP", "FRLNGP", JdeDataType.String, 4),
        new JdeField("FRSYR", "FRSYR", JdeDataType.String, 8),
        new JdeField("FRDSCA", "FRDSCA", JdeDataType.String, 80),
        new JdeField("FRDSCC", "FRDSCC", JdeDataType.String, 80),
        new JdeField("FRSCRN", "FRSCRN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
    };
}
