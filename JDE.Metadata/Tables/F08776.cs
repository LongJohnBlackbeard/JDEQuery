using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08776 - .
/// </summary>
public class F08776 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XOTINC.
        /// </summary>
        public const string XOTINC = "XOTINC";

        /// <summary>
        /// XOHMCO.
        /// </summary>
        public const string XOHMCO = "XOHMCO";

        /// <summary>
        /// XOORMCU.
        /// </summary>
        public const string XOORMCU = "XOORMCU";

        /// <summary>
        /// XOJGRP.
        /// </summary>
        public const string XOJGRP = "XOJGRP";

        /// <summary>
        /// XOAPRR.
        /// </summary>
        public const string XOAPRR = "XOAPRR";

        /// <summary>
        /// XOLNGP.
        /// </summary>
        public const string XOLNGP = "XOLNGP";

        /// <summary>
        /// XOUSER.
        /// </summary>
        public const string XOUSER = "XOUSER";

        /// <summary>
        /// XOPID.
        /// </summary>
        public const string XOPID = "XOPID";

        /// <summary>
        /// XOJOBN.
        /// </summary>
        public const string XOJOBN = "XOJOBN";

        /// <summary>
        /// XOUPMJ.
        /// </summary>
        public const string XOUPMJ = "XOUPMJ";

        /// <summary>
        /// XOUPMT.
        /// </summary>
        public const string XOUPMT = "XOUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08776";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XOTINC", "XOTINC", JdeDataType.String, 2, true, true),
        new JdeField("XOHMCO", "XOHMCO", JdeDataType.String, 10, true, true),
        new JdeField("XOORMCU", "XOORMCU", JdeDataType.String, 24, true, true),
        new JdeField("XOJGRP", "XOJGRP", JdeDataType.String, 12, true, true),
        new JdeField("XOAPRR", "XOAPRR", JdeDataType.String, 10, true, true),
        new JdeField("XOLNGP", "XOLNGP", JdeDataType.String, 4, true, true),
        new JdeField("XOUSER", "XOUSER", JdeDataType.String, 20),
        new JdeField("XOPID", "XOPID", JdeDataType.String, 20),
        new JdeField("XOJOBN", "XOJOBN", JdeDataType.String, 20),
        new JdeField("XOUPMJ", "XOUPMJ", JdeDataType.Numeric),
        new JdeField("XOUPMT", "XOUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08776_0", "Primary Key on XOTINC, XOHMCO, XOORMCU, XOJGRP, XOAPRR, XOLNGP", new[] { "XOTINC", "XOHMCO", "XOORMCU", "XOJGRP", "XOAPRR", "XOLNGP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08776_2", "Index on SYS_NC00012$, SYS_NC00013$, SYS_NC00014$, SYS_NC00015$, SYS_NC00016$, SYS_NC00017$", new[] { "SYS_NC00012$", "SYS_NC00013$", "SYS_NC00014$", "SYS_NC00015$", "SYS_NC00016$", "SYS_NC00017$" })
    };
}
