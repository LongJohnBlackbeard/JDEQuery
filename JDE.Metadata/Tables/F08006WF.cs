using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08006WF - .
/// </summary>
public class F08006WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JCPUKID.
        /// </summary>
        public const string JCPUKID = "JCPUKID";

        /// <summary>
        /// JCUKID.
        /// </summary>
        public const string JCUKID = "JCUKID";

        /// <summary>
        /// JCOTPS.
        /// </summary>
        public const string JCOTPS = "JCOTPS";

        /// <summary>
        /// JCJCC.
        /// </summary>
        public const string JCJCC = "JCJCC";

        /// <summary>
        /// JCJGRP.
        /// </summary>
        public const string JCJGRP = "JCJGRP";

        /// <summary>
        /// JCORMCU.
        /// </summary>
        public const string JCORMCU = "JCORMCU";

        /// <summary>
        /// JCJBCD.
        /// </summary>
        public const string JCJBCD = "JCJBCD";

        /// <summary>
        /// JCJBST.
        /// </summary>
        public const string JCJBST = "JCJBST";

        /// <summary>
        /// JCEFTB.
        /// </summary>
        public const string JCEFTB = "JCEFTB";

        /// <summary>
        /// JCEFTE.
        /// </summary>
        public const string JCEFTE = "JCEFTE";

        /// <summary>
        /// JCOVEX1.
        /// </summary>
        public const string JCOVEX1 = "JCOVEX1";

        /// <summary>
        /// JCOVEX2.
        /// </summary>
        public const string JCOVEX2 = "JCOVEX2";

        /// <summary>
        /// JCOVEX3.
        /// </summary>
        public const string JCOVEX3 = "JCOVEX3";

        /// <summary>
        /// JCOVEX4.
        /// </summary>
        public const string JCOVEX4 = "JCOVEX4";

        /// <summary>
        /// JCOVEX5.
        /// </summary>
        public const string JCOVEX5 = "JCOVEX5";

        /// <summary>
        /// JCOVEX6.
        /// </summary>
        public const string JCOVEX6 = "JCOVEX6";

        /// <summary>
        /// JCOVEX7.
        /// </summary>
        public const string JCOVEX7 = "JCOVEX7";

        /// <summary>
        /// JCOVEX8.
        /// </summary>
        public const string JCOVEX8 = "JCOVEX8";

        /// <summary>
        /// JCJCCS.
        /// </summary>
        public const string JCJCCS = "JCJCCS";

        /// <summary>
        /// JCDOFLG.
        /// </summary>
        public const string JCDOFLG = "JCDOFLG";
    }

    /// <inheritdoc />
    public override string TableName => "F08006WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JCPUKID", "JCPUKID", JdeDataType.Numeric),
        new JdeField("JCUKID", "JCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("JCOTPS", "JCOTPS", JdeDataType.String, 6, true, true),
        new JdeField("JCJCC", "JCJCC", JdeDataType.String, 20),
        new JdeField("JCJGRP", "JCJGRP", JdeDataType.String, 12),
        new JdeField("JCORMCU", "JCORMCU", JdeDataType.String, 24),
        new JdeField("JCJBCD", "JCJBCD", JdeDataType.String, 12),
        new JdeField("JCJBST", "JCJBST", JdeDataType.String, 8),
        new JdeField("JCEFTB", "JCEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("JCEFTE", "JCEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("JCOVEX1", "JCOVEX1", JdeDataType.String, 2),
        new JdeField("JCOVEX2", "JCOVEX2", JdeDataType.String, 2),
        new JdeField("JCOVEX3", "JCOVEX3", JdeDataType.String, 2),
        new JdeField("JCOVEX4", "JCOVEX4", JdeDataType.String, 2),
        new JdeField("JCOVEX5", "JCOVEX5", JdeDataType.String, 2),
        new JdeField("JCOVEX6", "JCOVEX6", JdeDataType.String, 2),
        new JdeField("JCOVEX7", "JCOVEX7", JdeDataType.String, 2),
        new JdeField("JCOVEX8", "JCOVEX8", JdeDataType.String, 2),
        new JdeField("JCJCCS", "JCJCCS", JdeDataType.String, 126),
        new JdeField("JCDOFLG", "JCDOFLG", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08006WF_0", "Primary Key on JCUKID, JCOTPS, JCEFTB, JCEFTE, JCDOFLG", new[] { "JCUKID", "JCOTPS", "JCEFTB", "JCEFTE", "JCDOFLG" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08006WF_6", "Index on JCOTPS, JCJCC, JCORMCU, JCJGRP, JCJBCD, JCJBST, JCEFTB, JCEFTE, JCDOFLG", new[] { "JCOTPS", "JCJCC", "JCORMCU", "JCJGRP", "JCJBCD", "JCJBST", "JCEFTB", "JCEFTE", "JCDOFLG" }),
        new JdeIndex("F08006WF_7", "Index on JCUKID, JCOTPS, JCEFTB, JCDOFLG", new[] { "JCUKID", "JCOTPS", "JCEFTB", "JCDOFLG" }),
        new JdeIndex("F08006WF_8", "Index on JCUKID, JCOTPS, JCEFTE, JCDOFLG", new[] { "JCUKID", "JCOTPS", "JCEFTE", "JCDOFLG" }),
        new JdeIndex("F08006WF_9", "Index on JCUKID, JCOTPS, JCDOFLG", new[] { "JCUKID", "JCOTPS", "JCDOFLG" })
    };
}
