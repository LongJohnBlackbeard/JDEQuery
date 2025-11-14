using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F749101 - .
/// </summary>
public class F749101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDE74RENA.
        /// </summary>
        public const string RDE74RENA = "RDE74RENA";

        /// <summary>
        /// RDE74REDE.
        /// </summary>
        public const string RDE74REDE = "RDE74REDE";

        /// <summary>
        /// RDE74RETY.
        /// </summary>
        public const string RDE74RETY = "RDE74RETY";

        /// <summary>
        /// RDE74MCUG.
        /// </summary>
        public const string RDE74MCUG = "RDE74MCUG";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDUPMT.
        /// </summary>
        public const string RDUPMT = "RDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F749101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDE74RENA", "RDE74RENA", JdeDataType.String, 40, true, true),
        new JdeField("RDE74REDE", "RDE74REDE", JdeDataType.String, 60),
        new JdeField("RDE74RETY", "RDE74RETY", JdeDataType.String, 8),
        new JdeField("RDE74MCUG", "RDE74MCUG", JdeDataType.String, 30),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDUPMT", "RDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F749101_0", "Primary Key on RDE74RENA", new[] { "RDE74RENA" }, isUnique: true, isPrimaryKey: true)
    };
}
