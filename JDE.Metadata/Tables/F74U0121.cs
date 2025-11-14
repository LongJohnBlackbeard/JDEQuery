using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0121 - .
/// </summary>
public class F74U0121 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MPKCOO.
        /// </summary>
        public const string MPKCOO = "MPKCOO";

        /// <summary>
        /// MPDOCO.
        /// </summary>
        public const string MPDOCO = "MPDOCO";

        /// <summary>
        /// MPDCTO.
        /// </summary>
        public const string MPDCTO = "MPDCTO";

        /// <summary>
        /// MPSFXO.
        /// </summary>
        public const string MPSFXO = "MPSFXO";

        /// <summary>
        /// MPLNID.
        /// </summary>
        public const string MPLNID = "MPLNID";

        /// <summary>
        /// MPEV01.
        /// </summary>
        public const string MPEV01 = "MPEV01";

        /// <summary>
        /// MPUSER.
        /// </summary>
        public const string MPUSER = "MPUSER";

        /// <summary>
        /// MPPID.
        /// </summary>
        public const string MPPID = "MPPID";

        /// <summary>
        /// MPUPDJ.
        /// </summary>
        public const string MPUPDJ = "MPUPDJ";

        /// <summary>
        /// MPUPMT.
        /// </summary>
        public const string MPUPMT = "MPUPMT";

        /// <summary>
        /// MPJOBN.
        /// </summary>
        public const string MPJOBN = "MPJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0121";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MPKCOO", "MPKCOO", JdeDataType.String, 10, true, true),
        new JdeField("MPDOCO", "MPDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("MPDCTO", "MPDCTO", JdeDataType.String, 4, true, true),
        new JdeField("MPSFXO", "MPSFXO", JdeDataType.String, 6, true, true),
        new JdeField("MPLNID", "MPLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("MPEV01", "MPEV01", JdeDataType.String, 2),
        new JdeField("MPUSER", "MPUSER", JdeDataType.String, 20),
        new JdeField("MPPID", "MPPID", JdeDataType.String, 20),
        new JdeField("MPUPDJ", "MPUPDJ", JdeDataType.Numeric),
        new JdeField("MPUPMT", "MPUPMT", JdeDataType.Numeric),
        new JdeField("MPJOBN", "MPJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0121_0", "Primary Key on MPKCOO, MPDOCO, MPDCTO, MPSFXO, MPLNID", new[] { "MPKCOO", "MPDOCO", "MPDCTO", "MPSFXO", "MPLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
