using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4318 - .
/// </summary>
public class F4318 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PYKCOO.
        /// </summary>
        public const string PYKCOO = "PYKCOO";

        /// <summary>
        /// PYDOCO.
        /// </summary>
        public const string PYDOCO = "PYDOCO";

        /// <summary>
        /// PYDCTO.
        /// </summary>
        public const string PYDCTO = "PYDCTO";

        /// <summary>
        /// PYSFXO.
        /// </summary>
        public const string PYSFXO = "PYSFXO";

        /// <summary>
        /// PYLNID.
        /// </summary>
        public const string PYLNID = "PYLNID";

        /// <summary>
        /// PYATXT.
        /// </summary>
        public const string PYATXT = "PYATXT";

        /// <summary>
        /// PYRMK.
        /// </summary>
        public const string PYRMK = "PYRMK";

        /// <summary>
        /// PYUC01.
        /// </summary>
        public const string PYUC01 = "PYUC01";

        /// <summary>
        /// PYUC02.
        /// </summary>
        public const string PYUC02 = "PYUC02";

        /// <summary>
        /// PYUC03.
        /// </summary>
        public const string PYUC03 = "PYUC03";

        /// <summary>
        /// PYUC04.
        /// </summary>
        public const string PYUC04 = "PYUC04";

        /// <summary>
        /// PYUC05.
        /// </summary>
        public const string PYUC05 = "PYUC05";

        /// <summary>
        /// PYUC06.
        /// </summary>
        public const string PYUC06 = "PYUC06";

        /// <summary>
        /// PYUC07.
        /// </summary>
        public const string PYUC07 = "PYUC07";

        /// <summary>
        /// PYUC08.
        /// </summary>
        public const string PYUC08 = "PYUC08";

        /// <summary>
        /// PYUC09.
        /// </summary>
        public const string PYUC09 = "PYUC09";

        /// <summary>
        /// PYUC10.
        /// </summary>
        public const string PYUC10 = "PYUC10";
    }

    /// <inheritdoc />
    public override string TableName => "F4318";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PYKCOO", "PYKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PYDOCO", "PYDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PYDCTO", "PYDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PYSFXO", "PYSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PYLNID", "PYLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PYATXT", "PYATXT", JdeDataType.String, 2),
        new JdeField("PYRMK", "PYRMK", JdeDataType.String, 60),
        new JdeField("PYUC01", "PYUC01", JdeDataType.String, 2),
        new JdeField("PYUC02", "PYUC02", JdeDataType.String, 2),
        new JdeField("PYUC03", "PYUC03", JdeDataType.String, 2),
        new JdeField("PYUC04", "PYUC04", JdeDataType.String, 2),
        new JdeField("PYUC05", "PYUC05", JdeDataType.String, 2),
        new JdeField("PYUC06", "PYUC06", JdeDataType.String, 2),
        new JdeField("PYUC07", "PYUC07", JdeDataType.String, 2),
        new JdeField("PYUC08", "PYUC08", JdeDataType.String, 2),
        new JdeField("PYUC09", "PYUC09", JdeDataType.String, 2),
        new JdeField("PYUC10", "PYUC10", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4318_0", "Primary Key on PYDOCO, PYDCTO, PYKCOO, PYSFXO, PYLNID", new[] { "PYDOCO", "PYDCTO", "PYKCOO", "PYSFXO", "PYLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
