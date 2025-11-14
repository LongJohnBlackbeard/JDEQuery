using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U4318 - .
/// </summary>
public class F74U4318 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDKCOO.
        /// </summary>
        public const string SDKCOO = "SDKCOO";

        /// <summary>
        /// SDDOCO.
        /// </summary>
        public const string SDDOCO = "SDDOCO";

        /// <summary>
        /// SDDCTO.
        /// </summary>
        public const string SDDCTO = "SDDCTO";

        /// <summary>
        /// SDSFXO.
        /// </summary>
        public const string SDSFXO = "SDSFXO";

        /// <summary>
        /// SDLNID.
        /// </summary>
        public const string SDLNID = "SDLNID";

        /// <summary>
        /// SD74URLN.
        /// </summary>
        public const string SD74URLN = "SD74URLN";

        /// <summary>
        /// SDEFTE.
        /// </summary>
        public const string SDEFTE = "SDEFTE";

        /// <summary>
        /// SD74UPRET.
        /// </summary>
        public const string SD74UPRET = "SD74UPRET";

        /// <summary>
        /// SDURAT.
        /// </summary>
        public const string SDURAT = "SDURAT";

        /// <summary>
        /// SDURCD.
        /// </summary>
        public const string SDURCD = "SDURCD";

        /// <summary>
        /// SDURDT.
        /// </summary>
        public const string SDURDT = "SDURDT";

        /// <summary>
        /// SDURAB.
        /// </summary>
        public const string SDURAB = "SDURAB";

        /// <summary>
        /// SDURRF.
        /// </summary>
        public const string SDURRF = "SDURRF";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

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
    public override string TableName => "F74U4318";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDKCOO", "SDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SDDOCO", "SDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SDDCTO", "SDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SDSFXO", "SDSFXO", JdeDataType.String, 6, true, true),
        new JdeField("SDLNID", "SDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SD74URLN", "SD74URLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SDEFTE", "SDEFTE", JdeDataType.Numeric),
        new JdeField("SD74UPRET", "SD74UPRET", JdeDataType.Numeric),
        new JdeField("SDURAT", "SDURAT", JdeDataType.Numeric),
        new JdeField("SDURCD", "SDURCD", JdeDataType.String, 4),
        new JdeField("SDURDT", "SDURDT", JdeDataType.Numeric),
        new JdeField("SDURAB", "SDURAB", JdeDataType.Numeric),
        new JdeField("SDURRF", "SDURRF", JdeDataType.String, 30),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U4318_0", "Primary Key on SDKCOO, SDDOCO, SDDCTO, SDSFXO, SDLNID, SD74URLN", new[] { "SDKCOO", "SDDOCO", "SDDCTO", "SDSFXO", "SDLNID", "SD74URLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U4318_2", "Unique Index on SDKCOO, SDDOCO, SDDCTO, SDSFXO, SDLNID, SDEFTE", new[] { "SDKCOO", "SDDOCO", "SDDCTO", "SDSFXO", "SDLNID", "SDEFTE" }, isUnique: true)
    };
}
