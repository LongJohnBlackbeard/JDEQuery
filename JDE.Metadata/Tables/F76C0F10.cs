using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C0F10 - .
/// </summary>
public class F76C0F10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FSK74LECO.
        /// </summary>
        public const string FSK74LECO = "FSK74LECO";

        /// <summary>
        /// FSC76FMT.
        /// </summary>
        public const string FSC76FMT = "FSC76FMT";

        /// <summary>
        /// FSC76FSND.
        /// </summary>
        public const string FSC76FSND = "FSC76FSND";

        /// <summary>
        /// FSC76MIN.
        /// </summary>
        public const string FSC76MIN = "FSC76MIN";

        /// <summary>
        /// FSUSER.
        /// </summary>
        public const string FSUSER = "FSUSER";

        /// <summary>
        /// FSPID.
        /// </summary>
        public const string FSPID = "FSPID";

        /// <summary>
        /// FSJOBN.
        /// </summary>
        public const string FSJOBN = "FSJOBN";

        /// <summary>
        /// FSUPMJ.
        /// </summary>
        public const string FSUPMJ = "FSUPMJ";

        /// <summary>
        /// FSUPMT.
        /// </summary>
        public const string FSUPMT = "FSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76C0F10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FSK74LECO", "FSK74LECO", JdeDataType.String, 10, true, true),
        new JdeField("FSC76FMT", "FSC76FMT", JdeDataType.String, 10, true, true),
        new JdeField("FSC76FSND", "FSC76FSND", JdeDataType.Numeric),
        new JdeField("FSC76MIN", "FSC76MIN", JdeDataType.Numeric),
        new JdeField("FSUSER", "FSUSER", JdeDataType.String, 20),
        new JdeField("FSPID", "FSPID", JdeDataType.String, 20),
        new JdeField("FSJOBN", "FSJOBN", JdeDataType.String, 20),
        new JdeField("FSUPMJ", "FSUPMJ", JdeDataType.Numeric),
        new JdeField("FSUPMT", "FSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C0F10_0", "Primary Key on FSC76FMT, FSK74LECO", new[] { "FSC76FMT", "FSK74LECO" }, isUnique: true, isPrimaryKey: true)
    };
}
