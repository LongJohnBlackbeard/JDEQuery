using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F98252 - .
/// </summary>
public class F98252 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BLBPULID.
        /// </summary>
        public const string BLBPULID = "BLBPULID";

        /// <summary>
        /// BLOMWPRJID.
        /// </summary>
        public const string BLOMWPRJID = "BLOMWPRJID";

        /// <summary>
        /// BLBPUGRP.
        /// </summary>
        public const string BLBPUGRP = "BLBPUGRP";

        /// <summary>
        /// BLBPUSGRP.
        /// </summary>
        public const string BLBPUSGRP = "BLBPUSGRP";

        /// <summary>
        /// BLBPUID.
        /// </summary>
        public const string BLBPUID = "BLBPUID";

        /// <summary>
        /// BLBPULFS.
        /// </summary>
        public const string BLBPULFS = "BLBPULFS";

        /// <summary>
        /// BLBPULTS.
        /// </summary>
        public const string BLBPULTS = "BLBPULTS";

        /// <summary>
        /// BLBPULPS.
        /// </summary>
        public const string BLBPULPS = "BLBPULPS";

        /// <summary>
        /// BLBPULPU.
        /// </summary>
        public const string BLBPULPU = "BLBPULPU";

        /// <summary>
        /// BLBPULPD.
        /// </summary>
        public const string BLBPULPD = "BLBPULPD";

        /// <summary>
        /// BLBPULPT.
        /// </summary>
        public const string BLBPULPT = "BLBPULPT";

        /// <summary>
        /// BLBPUFUS1.
        /// </summary>
        public const string BLBPUFUS1 = "BLBPUFUS1";

        /// <summary>
        /// BLBPUFUS2.
        /// </summary>
        public const string BLBPUFUS2 = "BLBPUFUS2";

        /// <summary>
        /// BLBPUFUMN1.
        /// </summary>
        public const string BLBPUFUMN1 = "BLBPUFUMN1";

        /// <summary>
        /// BLBPUFUMN2.
        /// </summary>
        public const string BLBPUFUMN2 = "BLBPUFUMN2";

        /// <summary>
        /// BLBPUFUD1.
        /// </summary>
        public const string BLBPUFUD1 = "BLBPUFUD1";

        /// <summary>
        /// BLBPUFUD2.
        /// </summary>
        public const string BLBPUFUD2 = "BLBPUFUD2";

        /// <summary>
        /// BLPID.
        /// </summary>
        public const string BLPID = "BLPID";

        /// <summary>
        /// BLMKEY.
        /// </summary>
        public const string BLMKEY = "BLMKEY";

        /// <summary>
        /// BLUSER.
        /// </summary>
        public const string BLUSER = "BLUSER";

        /// <summary>
        /// BLUPMJ.
        /// </summary>
        public const string BLUPMJ = "BLUPMJ";

        /// <summary>
        /// BLUPMT.
        /// </summary>
        public const string BLUPMT = "BLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F98252";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BLBPULID", "BLBPULID", JdeDataType.Numeric, null, true, true),
        new JdeField("BLOMWPRJID", "BLOMWPRJID", JdeDataType.String, 60),
        new JdeField("BLBPUGRP", "BLBPUGRP", JdeDataType.String, 60),
        new JdeField("BLBPUSGRP", "BLBPUSGRP", JdeDataType.String, 60),
        new JdeField("BLBPUID", "BLBPUID", JdeDataType.Numeric),
        new JdeField("BLBPULFS", "BLBPULFS", JdeDataType.String, 10),
        new JdeField("BLBPULTS", "BLBPULTS", JdeDataType.String, 10),
        new JdeField("BLBPULPS", "BLBPULPS", JdeDataType.String, 20),
        new JdeField("BLBPULPU", "BLBPULPU", JdeDataType.String, 20),
        new JdeField("BLBPULPD", "BLBPULPD", JdeDataType.Numeric),
        new JdeField("BLBPULPT", "BLBPULPT", JdeDataType.Numeric),
        new JdeField("BLBPUFUS1", "BLBPUFUS1", JdeDataType.String, 60),
        new JdeField("BLBPUFUS2", "BLBPUFUS2", JdeDataType.String, 60),
        new JdeField("BLBPUFUMN1", "BLBPUFUMN1", JdeDataType.Numeric),
        new JdeField("BLBPUFUMN2", "BLBPUFUMN2", JdeDataType.Numeric),
        new JdeField("BLBPUFUD1", "BLBPUFUD1", JdeDataType.Numeric),
        new JdeField("BLBPUFUD2", "BLBPUFUD2", JdeDataType.Numeric),
        new JdeField("BLPID", "BLPID", JdeDataType.String, 20),
        new JdeField("BLMKEY", "BLMKEY", JdeDataType.String, 30),
        new JdeField("BLUSER", "BLUSER", JdeDataType.String, 20),
        new JdeField("BLUPMJ", "BLUPMJ", JdeDataType.Numeric),
        new JdeField("BLUPMT", "BLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F98252_0", "Primary Key on BLBPULID", new[] { "BLBPULID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F98252_1", "Unique Index on BLBPULID, BLBPUGRP, BLBPUSGRP, BLOMWPRJID, BLBPUID", new[] { "BLBPULID", "BLBPUGRP", "BLBPUSGRP", "BLOMWPRJID", "BLBPUID" }, isUnique: true),
        new JdeIndex("F98252_2", "Index on BLBPUGRP", new[] { "BLBPUGRP" }),
        new JdeIndex("F98252_3", "Index on BLBPUGRP, BLBPUSGRP", new[] { "BLBPUGRP", "BLBPUSGRP" }),
        new JdeIndex("F98252_4", "Index on BLBPUGRP, BLBPUSGRP, BLOMWPRJID", new[] { "BLBPUGRP", "BLBPUSGRP", "BLOMWPRJID" }),
        new JdeIndex("F98252_5", "Index on BLBPUGRP, BLBPUSGRP, BLOMWPRJID, BLBPUID", new[] { "BLBPUGRP", "BLBPUSGRP", "BLOMWPRJID", "BLBPUID" }),
        new JdeIndex("F98252_7", "Index on BLOMWPRJID", new[] { "BLOMWPRJID" }),
        new JdeIndex("F98252_8", "Index on BLBPULID, BLOMWPRJID", new[] { "BLBPULID", "BLOMWPRJID" })
    };
}
