using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08JDWF1 - .
/// </summary>
public class F08JDWF1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JCJOBS.
        /// </summary>
        public const string JCJOBS = "JCJOBS";

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
        /// JCJCC.
        /// </summary>
        public const string JCJCC = "JCJCC";

        /// <summary>
        /// JCUKID.
        /// </summary>
        public const string JCUKID = "JCUKID";

        /// <summary>
        /// JCRULEN.
        /// </summary>
        public const string JCRULEN = "JCRULEN";

        /// <summary>
        /// JCTBLE.
        /// </summary>
        public const string JCTBLE = "JCTBLE";

        /// <summary>
        /// JCACFL.
        /// </summary>
        public const string JCACFL = "JCACFL";

        /// <summary>
        /// JCPROCFLG.
        /// </summary>
        public const string JCPROCFLG = "JCPROCFLG";

        /// <summary>
        /// JCUSER.
        /// </summary>
        public const string JCUSER = "JCUSER";

        /// <summary>
        /// JCPID.
        /// </summary>
        public const string JCPID = "JCPID";

        /// <summary>
        /// JCUPMJ.
        /// </summary>
        public const string JCUPMJ = "JCUPMJ";

        /// <summary>
        /// JCUPMT.
        /// </summary>
        public const string JCUPMT = "JCUPMT";

        /// <summary>
        /// JCMKEY.
        /// </summary>
        public const string JCMKEY = "JCMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F08JDWF1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JCJOBS", "JCJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("JCEFTB", "JCEFTB", JdeDataType.Numeric),
        new JdeField("JCEFTE", "JCEFTE", JdeDataType.Numeric),
        new JdeField("JCOTPS", "JCOTPS", JdeDataType.String, 6),
        new JdeField("JCJGRP", "JCJGRP", JdeDataType.String, 12),
        new JdeField("JCORMCU", "JCORMCU", JdeDataType.String, 24),
        new JdeField("JCJBCD", "JCJBCD", JdeDataType.String, 12),
        new JdeField("JCJBST", "JCJBST", JdeDataType.String, 8),
        new JdeField("JCJCC", "JCJCC", JdeDataType.String, 20),
        new JdeField("JCUKID", "JCUKID", JdeDataType.Numeric),
        new JdeField("JCRULEN", "JCRULEN", JdeDataType.Numeric),
        new JdeField("JCTBLE", "JCTBLE", JdeDataType.String, 60),
        new JdeField("JCACFL", "JCACFL", JdeDataType.String, 2),
        new JdeField("JCPROCFLG", "JCPROCFLG", JdeDataType.Numeric),
        new JdeField("JCUSER", "JCUSER", JdeDataType.String, 20),
        new JdeField("JCPID", "JCPID", JdeDataType.String, 20),
        new JdeField("JCUPMJ", "JCUPMJ", JdeDataType.Numeric),
        new JdeField("JCUPMT", "JCUPMT", JdeDataType.Numeric),
        new JdeField("JCMKEY", "JCMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08JDWF1_0", "Primary Key on JCJOBS", new[] { "JCJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
