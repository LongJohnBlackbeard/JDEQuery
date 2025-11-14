using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F98250 - .
/// </summary>
public class F98250 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BPBPUGRP.
        /// </summary>
        public const string BPBPUGRP = "BPBPUGRP";

        /// <summary>
        /// BPBPUSGRP.
        /// </summary>
        public const string BPBPUSGRP = "BPBPUSGRP";

        /// <summary>
        /// BPOMWPRJID.
        /// </summary>
        public const string BPOMWPRJID = "BPOMWPRJID";

        /// <summary>
        /// BPBPUID.
        /// </summary>
        public const string BPBPUID = "BPBPUID";

        /// <summary>
        /// BPBPUSACT.
        /// </summary>
        public const string BPBPUSACT = "BPBPUSACT";

        /// <summary>
        /// BPBPUPACT.
        /// </summary>
        public const string BPBPUPACT = "BPBPUPACT";

        /// <summary>
        /// BPBPUSSUC.
        /// </summary>
        public const string BPBPUSSUC = "BPBPUSSUC";

        /// <summary>
        /// BPBPUPSUC.
        /// </summary>
        public const string BPBPUPSUC = "BPBPUPSUC";

        /// <summary>
        /// BPBPUFRST.
        /// </summary>
        public const string BPBPUFRST = "BPBPUFRST";

        /// <summary>
        /// BPBPUTOST.
        /// </summary>
        public const string BPBPUTOST = "BPBPUTOST";

        /// <summary>
        /// BPBPUSORD.
        /// </summary>
        public const string BPBPUSORD = "BPBPUSORD";

        /// <summary>
        /// BPBPUPORD.
        /// </summary>
        public const string BPBPUPORD = "BPBPUPORD";

        /// <summary>
        /// BPBPUFUS1.
        /// </summary>
        public const string BPBPUFUS1 = "BPBPUFUS1";

        /// <summary>
        /// BPBPUFUS2.
        /// </summary>
        public const string BPBPUFUS2 = "BPBPUFUS2";

        /// <summary>
        /// BPBPUFUMN1.
        /// </summary>
        public const string BPBPUFUMN1 = "BPBPUFUMN1";

        /// <summary>
        /// BPBPUFUMN2.
        /// </summary>
        public const string BPBPUFUMN2 = "BPBPUFUMN2";

        /// <summary>
        /// BPBPUFUD1.
        /// </summary>
        public const string BPBPUFUD1 = "BPBPUFUD1";

        /// <summary>
        /// BPBPUFUD2.
        /// </summary>
        public const string BPBPUFUD2 = "BPBPUFUD2";

        /// <summary>
        /// BPPID.
        /// </summary>
        public const string BPPID = "BPPID";

        /// <summary>
        /// BPMKEY.
        /// </summary>
        public const string BPMKEY = "BPMKEY";

        /// <summary>
        /// BPUSER.
        /// </summary>
        public const string BPUSER = "BPUSER";

        /// <summary>
        /// BPUPMJ.
        /// </summary>
        public const string BPUPMJ = "BPUPMJ";

        /// <summary>
        /// BPUPMT.
        /// </summary>
        public const string BPUPMT = "BPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F98250";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BPBPUGRP", "BPBPUGRP", JdeDataType.String, 60, true, true),
        new JdeField("BPBPUSGRP", "BPBPUSGRP", JdeDataType.String, 60, true, true),
        new JdeField("BPOMWPRJID", "BPOMWPRJID", JdeDataType.String, 60, true, true),
        new JdeField("BPBPUID", "BPBPUID", JdeDataType.Numeric, null, true, true),
        new JdeField("BPBPUSACT", "BPBPUSACT", JdeDataType.String, 20),
        new JdeField("BPBPUPACT", "BPBPUPACT", JdeDataType.String, 20),
        new JdeField("BPBPUSSUC", "BPBPUSSUC", JdeDataType.String, 20),
        new JdeField("BPBPUPSUC", "BPBPUPSUC", JdeDataType.String, 20),
        new JdeField("BPBPUFRST", "BPBPUFRST", JdeDataType.String, 10),
        new JdeField("BPBPUTOST", "BPBPUTOST", JdeDataType.String, 10),
        new JdeField("BPBPUSORD", "BPBPUSORD", JdeDataType.Numeric),
        new JdeField("BPBPUPORD", "BPBPUPORD", JdeDataType.Numeric),
        new JdeField("BPBPUFUS1", "BPBPUFUS1", JdeDataType.String, 60),
        new JdeField("BPBPUFUS2", "BPBPUFUS2", JdeDataType.String, 60),
        new JdeField("BPBPUFUMN1", "BPBPUFUMN1", JdeDataType.Numeric),
        new JdeField("BPBPUFUMN2", "BPBPUFUMN2", JdeDataType.Numeric),
        new JdeField("BPBPUFUD1", "BPBPUFUD1", JdeDataType.Numeric),
        new JdeField("BPBPUFUD2", "BPBPUFUD2", JdeDataType.Numeric),
        new JdeField("BPPID", "BPPID", JdeDataType.String, 20),
        new JdeField("BPMKEY", "BPMKEY", JdeDataType.String, 30),
        new JdeField("BPUSER", "BPUSER", JdeDataType.String, 20),
        new JdeField("BPUPMJ", "BPUPMJ", JdeDataType.Numeric),
        new JdeField("BPUPMT", "BPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F98250_0", "Primary Key on BPBPUGRP, BPBPUSGRP, BPOMWPRJID, BPBPUID", new[] { "BPBPUGRP", "BPBPUSGRP", "BPOMWPRJID", "BPBPUID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F98250_10", "Index on BPBPUGRP, BPBPUSGRP, BPOMWPRJID, BPBPUPORD, BPBPUID", new[] { "BPBPUGRP", "BPBPUSGRP", "BPOMWPRJID", "BPBPUPORD", "BPBPUID" }),
        new JdeIndex("F98250_11", "Unique Index on BPBPUGRP, BPBPUSGRP, BPOMWPRJID, BPBPUFRST, BPBPUTOST", new[] { "BPBPUGRP", "BPBPUSGRP", "BPOMWPRJID", "BPBPUFRST", "BPBPUTOST" }, isUnique: true),
        new JdeIndex("F98250_2", "Index on BPBPUGRP, BPBPUSGRP", new[] { "BPBPUGRP", "BPBPUSGRP" }),
        new JdeIndex("F98250_3", "Index on BPBPUSGRP, BPOMWPRJID", new[] { "BPBPUSGRP", "BPOMWPRJID" }),
        new JdeIndex("F98250_4", "Index on BPBPUID, BPBPUPACT, BPBPUPSUC, BPBPUPORD", new[] { "BPBPUID", "BPBPUPACT", "BPBPUPSUC", "BPBPUPORD" }),
        new JdeIndex("F98250_6", "Index on BPBPUGRP", new[] { "BPBPUGRP" }),
        new JdeIndex("F98250_7", "Index on BPBPUGRP, BPBPUSGRP, BPOMWPRJID", new[] { "BPBPUGRP", "BPBPUSGRP", "BPOMWPRJID" }),
        new JdeIndex("F98250_9", "Index on BPBPUGRP, BPBPUSGRP, BPBPUSORD", new[] { "BPBPUGRP", "BPBPUSGRP", "BPBPUSORD" })
    };
}
