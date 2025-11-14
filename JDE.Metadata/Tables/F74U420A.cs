using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U420A - .
/// </summary>
public class F74U420A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PAUKAPNM.
        /// </summary>
        public const string PAUKAPNM = "PAUKAPNM";

        /// <summary>
        /// PADOCO.
        /// </summary>
        public const string PADOCO = "PADOCO";

        /// <summary>
        /// PADCTO.
        /// </summary>
        public const string PADCTO = "PADCTO";

        /// <summary>
        /// PAKCOO.
        /// </summary>
        public const string PAKCOO = "PAKCOO";

        /// <summary>
        /// PASFXO.
        /// </summary>
        public const string PASFXO = "PASFXO";

        /// <summary>
        /// PA74UALN.
        /// </summary>
        public const string PA74UALN = "PA74UALN";

        /// <summary>
        /// PALNID.
        /// </summary>
        public const string PALNID = "PALNID";

        /// <summary>
        /// PAUKAPAM.
        /// </summary>
        public const string PAUKAPAM = "PAUKAPAM";

        /// <summary>
        /// PA74UDS60.
        /// </summary>
        public const string PA74UDS60 = "PA74UDS60";

        /// <summary>
        /// PA74UDS30A.
        /// </summary>
        public const string PA74UDS30A = "PA74UDS30A";

        /// <summary>
        /// PA74UDS30B.
        /// </summary>
        public const string PA74UDS30B = "PA74UDS30B";

        /// <summary>
        /// PA74UDS30C.
        /// </summary>
        public const string PA74UDS30C = "PA74UDS30C";

        /// <summary>
        /// PAAN81.
        /// </summary>
        public const string PAAN81 = "PAAN81";

        /// <summary>
        /// PASBL.
        /// </summary>
        public const string PASBL = "PASBL";

        /// <summary>
        /// PASBLT.
        /// </summary>
        public const string PASBLT = "PASBLT";

        /// <summary>
        /// PAEFFF.
        /// </summary>
        public const string PAEFFF = "PAEFFF";

        /// <summary>
        /// PAEFFT.
        /// </summary>
        public const string PAEFFT = "PAEFFT";

        /// <summary>
        /// PAUSER.
        /// </summary>
        public const string PAUSER = "PAUSER";

        /// <summary>
        /// PAPID.
        /// </summary>
        public const string PAPID = "PAPID";

        /// <summary>
        /// PAJOBN.
        /// </summary>
        public const string PAJOBN = "PAJOBN";

        /// <summary>
        /// PAUPMJ.
        /// </summary>
        public const string PAUPMJ = "PAUPMJ";

        /// <summary>
        /// PAUPMT.
        /// </summary>
        public const string PAUPMT = "PAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74U420A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PAUKAPNM", "PAUKAPNM", JdeDataType.Numeric, null, true, true),
        new JdeField("PADOCO", "PADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PADCTO", "PADCTO", JdeDataType.String, 4, true, true),
        new JdeField("PAKCOO", "PAKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PASFXO", "PASFXO", JdeDataType.String, 6, true, true),
        new JdeField("PA74UALN", "PA74UALN", JdeDataType.Numeric, null, true, true),
        new JdeField("PALNID", "PALNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PAUKAPAM", "PAUKAPAM", JdeDataType.Numeric),
        new JdeField("PA74UDS60", "PA74UDS60", JdeDataType.String, 120),
        new JdeField("PA74UDS30A", "PA74UDS30A", JdeDataType.String, 120),
        new JdeField("PA74UDS30B", "PA74UDS30B", JdeDataType.String, 120),
        new JdeField("PA74UDS30C", "PA74UDS30C", JdeDataType.String, 120),
        new JdeField("PAAN81", "PAAN81", JdeDataType.Numeric),
        new JdeField("PASBL", "PASBL", JdeDataType.String, 16),
        new JdeField("PASBLT", "PASBLT", JdeDataType.String, 2),
        new JdeField("PAEFFF", "PAEFFF", JdeDataType.Numeric),
        new JdeField("PAEFFT", "PAEFFT", JdeDataType.Numeric),
        new JdeField("PAUSER", "PAUSER", JdeDataType.String, 20),
        new JdeField("PAPID", "PAPID", JdeDataType.String, 20),
        new JdeField("PAJOBN", "PAJOBN", JdeDataType.String, 20),
        new JdeField("PAUPMJ", "PAUPMJ", JdeDataType.Numeric),
        new JdeField("PAUPMT", "PAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U420A_0", "Primary Key on PAUKAPNM, PADOCO, PADCTO, PAKCOO, PASFXO, PA74UALN, PALNID", new[] { "PAUKAPNM", "PADOCO", "PADCTO", "PAKCOO", "PASFXO", "PA74UALN", "PALNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U420A_2", "Index on PAUKAPNM, PADOCO, PADCTO, PAKCOO, PASFXO, PA74UALN", new[] { "PAUKAPNM", "PADOCO", "PADCTO", "PAKCOO", "PASFXO", "PA74UALN" })
    };
}
