using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F749102 - .
/// </summary>
public class F749102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDE74RENA.
        /// </summary>
        public const string SDE74RENA = "SDE74RENA";

        /// <summary>
        /// SDE74RSN.
        /// </summary>
        public const string SDE74RSN = "SDE74RSN";

        /// <summary>
        /// SDE74STIS.
        /// </summary>
        public const string SDE74STIS = "SDE74STIS";

        /// <summary>
        /// SDE74STIL.
        /// </summary>
        public const string SDE74STIL = "SDE74STIL";

        /// <summary>
        /// SDE74STO.
        /// </summary>
        public const string SDE74STO = "SDE74STO";

        /// <summary>
        /// SDE74STT.
        /// </summary>
        public const string SDE74STT = "SDE74STT";

        /// <summary>
        /// SDE74SBA.
        /// </summary>
        public const string SDE74SBA = "SDE74SBA";

        /// <summary>
        /// SDE74MCUG.
        /// </summary>
        public const string SDE74MCUG = "SDE74MCUG";

        /// <summary>
        /// SDE74VIS.
        /// </summary>
        public const string SDE74VIS = "SDE74VIS";

        /// <summary>
        /// SDE74SNOC.
        /// </summary>
        public const string SDE74SNOC = "SDE74SNOC";

        /// <summary>
        /// SDE74SETY.
        /// </summary>
        public const string SDE74SETY = "SDE74SETY";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F749102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDE74RENA", "SDE74RENA", JdeDataType.String, 40, true, true),
        new JdeField("SDE74RSN", "SDE74RSN", JdeDataType.Numeric, null, true, true),
        new JdeField("SDE74STIS", "SDE74STIS", JdeDataType.String, 60),
        new JdeField("SDE74STIL", "SDE74STIL", JdeDataType.String, 200),
        new JdeField("SDE74STO", "SDE74STO", JdeDataType.String, 2),
        new JdeField("SDE74STT", "SDE74STT", JdeDataType.String, 200),
        new JdeField("SDE74SBA", "SDE74SBA", JdeDataType.String, 2),
        new JdeField("SDE74MCUG", "SDE74MCUG", JdeDataType.String, 30),
        new JdeField("SDE74VIS", "SDE74VIS", JdeDataType.String, 2),
        new JdeField("SDE74SNOC", "SDE74SNOC", JdeDataType.Numeric),
        new JdeField("SDE74SETY", "SDE74SETY", JdeDataType.String, 4),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F749102_0", "Primary Key on SDE74RENA, SDE74RSN", new[] { "SDE74RENA", "SDE74RSN" }, isUnique: true, isPrimaryKey: true)
    };
}
