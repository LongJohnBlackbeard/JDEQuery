using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0029 - .
/// </summary>
public class F0029 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFTA1.
        /// </summary>
        public const string TFTA1 = "TFTA1";

        /// <summary>
        /// TFTXR1.
        /// </summary>
        public const string TFTXR1 = "TFTXR1";

        /// <summary>
        /// TFTOTO.
        /// </summary>
        public const string TFTOTO = "TFTOTO";

        /// <summary>
        /// TFSRET.
        /// </summary>
        public const string TFSRET = "TFSRET";

        /// <summary>
        /// TFATXA.
        /// </summary>
        public const string TFATXA = "TFATXA";

        /// <summary>
        /// TFATXN.
        /// </summary>
        public const string TFATXN = "TFATXN";

        /// <summary>
        /// TFTAXE.
        /// </summary>
        public const string TFTAXE = "TFTAXE";

        /// <summary>
        /// TFSTAM.
        /// </summary>
        public const string TFSTAM = "TFSTAM";

        /// <summary>
        /// TFCO.
        /// </summary>
        public const string TFCO = "TFCO";

        /// <summary>
        /// TFMCU.
        /// </summary>
        public const string TFMCU = "TFMCU";

        /// <summary>
        /// TFDOCO.
        /// </summary>
        public const string TFDOCO = "TFDOCO";

        /// <summary>
        /// TFAN8.
        /// </summary>
        public const string TFAN8 = "TFAN8";

        /// <summary>
        /// TFDCTO.
        /// </summary>
        public const string TFDCTO = "TFDCTO";

        /// <summary>
        /// TFKCOO.
        /// </summary>
        public const string TFKCOO = "TFKCOO";
    }

    /// <inheritdoc />
    public override string TableName => "F0029";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFTA1", "TFTA1", JdeDataType.Numeric, null, true, true),
        new JdeField("TFTXR1", "TFTXR1", JdeDataType.Numeric, null, true, true),
        new JdeField("TFTOTO", "TFTOTO", JdeDataType.Numeric),
        new JdeField("TFSRET", "TFSRET", JdeDataType.Numeric),
        new JdeField("TFATXA", "TFATXA", JdeDataType.Numeric),
        new JdeField("TFATXN", "TFATXN", JdeDataType.Numeric),
        new JdeField("TFTAXE", "TFTAXE", JdeDataType.Numeric),
        new JdeField("TFSTAM", "TFSTAM", JdeDataType.Numeric),
        new JdeField("TFCO", "TFCO", JdeDataType.String, 10, true, true),
        new JdeField("TFMCU", "TFMCU", JdeDataType.String, 24, true, true),
        new JdeField("TFDOCO", "TFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TFAN8", "TFAN8", JdeDataType.Numeric),
        new JdeField("TFDCTO", "TFDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TFKCOO", "TFKCOO", JdeDataType.String, 10, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0029_0", "Primary Key on TFCO, TFMCU, TFTA1, TFTXR1, TFDOCO, TFDCTO, TFKCOO", new[] { "TFCO", "TFMCU", "TFTA1", "TFTXR1", "TFDOCO", "TFDCTO", "TFKCOO" }, isUnique: true, isPrimaryKey: true)
    };
}
