using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46093 - .
/// </summary>
public class F46093 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMMCU.
        /// </summary>
        public const string EMMCU = "EMMCU";

        /// <summary>
        /// EMPRP7.
        /// </summary>
        public const string EMPRP7 = "EMPRP7";

        /// <summary>
        /// EMPRP8.
        /// </summary>
        public const string EMPRP8 = "EMPRP8";

        /// <summary>
        /// EMPRP9.
        /// </summary>
        public const string EMPRP9 = "EMPRP9";

        /// <summary>
        /// EMOGRP.
        /// </summary>
        public const string EMOGRP = "EMOGRP";

        /// <summary>
        /// EMMPUT.
        /// </summary>
        public const string EMMPUT = "EMMPUT";

        /// <summary>
        /// EMMPIK.
        /// </summary>
        public const string EMMPIK = "EMMPIK";

        /// <summary>
        /// EMMRPL.
        /// </summary>
        public const string EMMRPL = "EMMRPL";

        /// <summary>
        /// EMPUTP.
        /// </summary>
        public const string EMPUTP = "EMPUTP";

        /// <summary>
        /// EMPIKP.
        /// </summary>
        public const string EMPIKP = "EMPIKP";

        /// <summary>
        /// EMRPLP.
        /// </summary>
        public const string EMRPLP = "EMRPLP";

        /// <summary>
        /// EMPRO1.
        /// </summary>
        public const string EMPRO1 = "EMPRO1";

        /// <summary>
        /// EMPRO2.
        /// </summary>
        public const string EMPRO2 = "EMPRO2";

        /// <summary>
        /// EMPRO3.
        /// </summary>
        public const string EMPRO3 = "EMPRO3";

        /// <summary>
        /// EMUSER.
        /// </summary>
        public const string EMUSER = "EMUSER";

        /// <summary>
        /// EMUPMJ.
        /// </summary>
        public const string EMUPMJ = "EMUPMJ";

        /// <summary>
        /// EMTDAY.
        /// </summary>
        public const string EMTDAY = "EMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46093";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMMCU", "EMMCU", JdeDataType.String, 24, true, true),
        new JdeField("EMPRP7", "EMPRP7", JdeDataType.String, 12, true, true),
        new JdeField("EMPRP8", "EMPRP8", JdeDataType.String, 12, true, true),
        new JdeField("EMPRP9", "EMPRP9", JdeDataType.String, 12, true, true),
        new JdeField("EMOGRP", "EMOGRP", JdeDataType.String, 8, true, true),
        new JdeField("EMMPUT", "EMMPUT", JdeDataType.String, 12),
        new JdeField("EMMPIK", "EMMPIK", JdeDataType.String, 12),
        new JdeField("EMMRPL", "EMMRPL", JdeDataType.String, 12),
        new JdeField("EMPUTP", "EMPUTP", JdeDataType.String, 2),
        new JdeField("EMPIKP", "EMPIKP", JdeDataType.String, 2),
        new JdeField("EMRPLP", "EMRPLP", JdeDataType.String, 2),
        new JdeField("EMPRO1", "EMPRO1", JdeDataType.String, 20),
        new JdeField("EMPRO2", "EMPRO2", JdeDataType.String, 20),
        new JdeField("EMPRO3", "EMPRO3", JdeDataType.String, 20),
        new JdeField("EMUSER", "EMUSER", JdeDataType.String, 20),
        new JdeField("EMUPMJ", "EMUPMJ", JdeDataType.Numeric),
        new JdeField("EMTDAY", "EMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46093_0", "Primary Key on EMMCU, EMPRP7, EMPRP8, EMPRP9, EMOGRP", new[] { "EMMCU", "EMPRP7", "EMPRP8", "EMPRP9", "EMOGRP" }, isUnique: true, isPrimaryKey: true)
    };
}
