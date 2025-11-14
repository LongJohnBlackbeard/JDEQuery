using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F087711B - .
/// </summary>
public class F087711B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XKSERK.
        /// </summary>
        public const string XKSERK = "XKSERK";

        /// <summary>
        /// XKDEFROLE.
        /// </summary>
        public const string XKDEFROLE = "XKDEFROLE";

        /// <summary>
        /// XKTINC.
        /// </summary>
        public const string XKTINC = "XKTINC";

        /// <summary>
        /// XKHMCO.
        /// </summary>
        public const string XKHMCO = "XKHMCO";

        /// <summary>
        /// XKORMCU.
        /// </summary>
        public const string XKORMCU = "XKORMCU";

        /// <summary>
        /// XKJGRP.
        /// </summary>
        public const string XKJGRP = "XKJGRP";

        /// <summary>
        /// XKAPRR.
        /// </summary>
        public const string XKAPRR = "XKAPRR";

        /// <summary>
        /// XKLNGP.
        /// </summary>
        public const string XKLNGP = "XKLNGP";

        /// <summary>
        /// XKPRGF.
        /// </summary>
        public const string XKPRGF = "XKPRGF";

        /// <summary>
        /// XKTORG.
        /// </summary>
        public const string XKTORG = "XKTORG";

        /// <summary>
        /// XKUSER.
        /// </summary>
        public const string XKUSER = "XKUSER";

        /// <summary>
        /// XKPID.
        /// </summary>
        public const string XKPID = "XKPID";

        /// <summary>
        /// XKJOBN.
        /// </summary>
        public const string XKJOBN = "XKJOBN";

        /// <summary>
        /// XKUPMJ.
        /// </summary>
        public const string XKUPMJ = "XKUPMJ";

        /// <summary>
        /// XKUPMT.
        /// </summary>
        public const string XKUPMT = "XKUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F087711B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XKSERK", "XKSERK", JdeDataType.Numeric, null, true, true),
        new JdeField("XKDEFROLE", "XKDEFROLE", JdeDataType.String, 2, true, true),
        new JdeField("XKTINC", "XKTINC", JdeDataType.String, 2),
        new JdeField("XKHMCO", "XKHMCO", JdeDataType.String, 10),
        new JdeField("XKORMCU", "XKORMCU", JdeDataType.String, 24),
        new JdeField("XKJGRP", "XKJGRP", JdeDataType.String, 12),
        new JdeField("XKAPRR", "XKAPRR", JdeDataType.String, 10),
        new JdeField("XKLNGP", "XKLNGP", JdeDataType.String, 4),
        new JdeField("XKPRGF", "XKPRGF", JdeDataType.String, 2),
        new JdeField("XKTORG", "XKTORG", JdeDataType.String, 20),
        new JdeField("XKUSER", "XKUSER", JdeDataType.String, 20),
        new JdeField("XKPID", "XKPID", JdeDataType.String, 20),
        new JdeField("XKJOBN", "XKJOBN", JdeDataType.String, 20),
        new JdeField("XKUPMJ", "XKUPMJ", JdeDataType.Numeric),
        new JdeField("XKUPMT", "XKUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F087711B_0", "Primary Key on XKSERK, XKDEFROLE", new[] { "XKSERK", "XKDEFROLE" }, isUnique: true, isPrimaryKey: true)
    };
}
