using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76431 - .
/// </summary>
public class F76431 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIDOCO.
        /// </summary>
        public const string PIDOCO = "PIDOCO";

        /// <summary>
        /// PIDCTO.
        /// </summary>
        public const string PIDCTO = "PIDCTO";

        /// <summary>
        /// PIKCOO.
        /// </summary>
        public const string PIKCOO = "PIKCOO";

        /// <summary>
        /// PISFXO.
        /// </summary>
        public const string PISFXO = "PISFXO";

        /// <summary>
        /// PIBNOP.
        /// </summary>
        public const string PIBNOP = "PIBNOP";

        /// <summary>
        /// PIBSOP.
        /// </summary>
        public const string PIBSOP = "PIBSOP";

        /// <summary>
        /// PIUSER.
        /// </summary>
        public const string PIUSER = "PIUSER";

        /// <summary>
        /// PIPID.
        /// </summary>
        public const string PIPID = "PIPID";

        /// <summary>
        /// PIJOBN.
        /// </summary>
        public const string PIJOBN = "PIJOBN";

        /// <summary>
        /// PIUPMJ.
        /// </summary>
        public const string PIUPMJ = "PIUPMJ";

        /// <summary>
        /// PITDAY.
        /// </summary>
        public const string PITDAY = "PITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76431";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIDOCO", "PIDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PIDCTO", "PIDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PIKCOO", "PIKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PISFXO", "PISFXO", JdeDataType.String, 6, true, true),
        new JdeField("PIBNOP", "PIBNOP", JdeDataType.Numeric),
        new JdeField("PIBSOP", "PIBSOP", JdeDataType.String, 4),
        new JdeField("PIUSER", "PIUSER", JdeDataType.String, 20),
        new JdeField("PIPID", "PIPID", JdeDataType.String, 20),
        new JdeField("PIJOBN", "PIJOBN", JdeDataType.String, 20),
        new JdeField("PIUPMJ", "PIUPMJ", JdeDataType.Numeric),
        new JdeField("PITDAY", "PITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76431_0", "Primary Key on PIDOCO, PIDCTO, PIKCOO, PISFXO", new[] { "PIDOCO", "PIDCTO", "PIKCOO", "PISFXO" }, isUnique: true, isPrimaryKey: true)
    };
}
