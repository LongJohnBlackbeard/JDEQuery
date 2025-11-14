using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0800612 - .
/// </summary>
public class F0800612 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JCUKID.
        /// </summary>
        public const string JCUKID = "JCUKID";

        /// <summary>
        /// JCLNGP.
        /// </summary>
        public const string JCLNGP = "JCLNGP";

        /// <summary>
        /// JCUSDD.
        /// </summary>
        public const string JCUSDD = "JCUSDD";

        /// <summary>
        /// JCEFTB.
        /// </summary>
        public const string JCEFTB = "JCEFTB";

        /// <summary>
        /// JCEFTE.
        /// </summary>
        public const string JCEFTE = "JCEFTE";

        /// <summary>
        /// JCOTPS.
        /// </summary>
        public const string JCOTPS = "JCOTPS";

        /// <summary>
        /// JCORMCU.
        /// </summary>
        public const string JCORMCU = "JCORMCU";

        /// <summary>
        /// JCJCC.
        /// </summary>
        public const string JCJCC = "JCJCC";

        /// <summary>
        /// JCJBCD.
        /// </summary>
        public const string JCJBCD = "JCJBCD";

        /// <summary>
        /// JCJBST.
        /// </summary>
        public const string JCJBST = "JCJBST";

        /// <summary>
        /// JCJGRP.
        /// </summary>
        public const string JCJGRP = "JCJGRP";

        /// <summary>
        /// JCPUKID.
        /// </summary>
        public const string JCPUKID = "JCPUKID";

        /// <summary>
        /// JCUSER.
        /// </summary>
        public const string JCUSER = "JCUSER";

        /// <summary>
        /// JCPID.
        /// </summary>
        public const string JCPID = "JCPID";

        /// <summary>
        /// JCJOBN.
        /// </summary>
        public const string JCJOBN = "JCJOBN";

        /// <summary>
        /// JCUPMJ.
        /// </summary>
        public const string JCUPMJ = "JCUPMJ";

        /// <summary>
        /// JCUPMT.
        /// </summary>
        public const string JCUPMT = "JCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0800612";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JCUKID", "JCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("JCLNGP", "JCLNGP", JdeDataType.String, 4, true, true),
        new JdeField("JCUSDD", "JCUSDD", JdeDataType.String, 10, true, true),
        new JdeField("JCEFTB", "JCEFTB", JdeDataType.Numeric),
        new JdeField("JCEFTE", "JCEFTE", JdeDataType.Numeric),
        new JdeField("JCOTPS", "JCOTPS", JdeDataType.String, 6, true, true),
        new JdeField("JCORMCU", "JCORMCU", JdeDataType.String, 24),
        new JdeField("JCJCC", "JCJCC", JdeDataType.String, 20),
        new JdeField("JCJBCD", "JCJBCD", JdeDataType.String, 12),
        new JdeField("JCJBST", "JCJBST", JdeDataType.String, 8),
        new JdeField("JCJGRP", "JCJGRP", JdeDataType.String, 12),
        new JdeField("JCPUKID", "JCPUKID", JdeDataType.Numeric),
        new JdeField("JCUSER", "JCUSER", JdeDataType.String, 20),
        new JdeField("JCPID", "JCPID", JdeDataType.String, 20),
        new JdeField("JCJOBN", "JCJOBN", JdeDataType.String, 20),
        new JdeField("JCUPMJ", "JCUPMJ", JdeDataType.Numeric),
        new JdeField("JCUPMT", "JCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0800612_0", "Primary Key on JCUKID, JCLNGP, JCUSDD, JCOTPS", new[] { "JCUKID", "JCLNGP", "JCUSDD", "JCOTPS" }, isUnique: true, isPrimaryKey: true)
    };
}
