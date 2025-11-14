using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46092 - .
/// </summary>
public class F46092 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OZMCU.
        /// </summary>
        public const string OZMCU = "OZMCU";

        /// <summary>
        /// OZOGRP.
        /// </summary>
        public const string OZOGRP = "OZOGRP";

        /// <summary>
        /// OZDCTO.
        /// </summary>
        public const string OZDCTO = "OZDCTO";

        /// <summary>
        /// OZUSER.
        /// </summary>
        public const string OZUSER = "OZUSER";

        /// <summary>
        /// OZUPMJ.
        /// </summary>
        public const string OZUPMJ = "OZUPMJ";

        /// <summary>
        /// OZTDAY.
        /// </summary>
        public const string OZTDAY = "OZTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46092";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OZMCU", "OZMCU", JdeDataType.String, 24, true, true),
        new JdeField("OZOGRP", "OZOGRP", JdeDataType.String, 8, true, true),
        new JdeField("OZDCTO", "OZDCTO", JdeDataType.String, 4, true, true),
        new JdeField("OZUSER", "OZUSER", JdeDataType.String, 20),
        new JdeField("OZUPMJ", "OZUPMJ", JdeDataType.Numeric),
        new JdeField("OZTDAY", "OZTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46092_0", "Primary Key on OZMCU, OZOGRP, OZDCTO", new[] { "OZMCU", "OZOGRP", "OZDCTO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46092_2", "Index on OZMCU, OZDCTO", new[] { "OZMCU", "OZDCTO" })
    };
}
