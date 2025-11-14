using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41081 - .
/// </summary>
public class F41081 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LSLOTGRP.
        /// </summary>
        public const string LSLOTGRP = "LSLOTGRP";

        /// <summary>
        /// LSMCU.
        /// </summary>
        public const string LSMCU = "LSMCU";

        /// <summary>
        /// LSDCTO.
        /// </summary>
        public const string LSDCTO = "LSDCTO";

        /// <summary>
        /// LSLOTS.
        /// </summary>
        public const string LSLOTS = "LSLOTS";

        /// <summary>
        /// LSUEFFF.
        /// </summary>
        public const string LSUEFFF = "LSUEFFF";

        /// <summary>
        /// LSUEFFT.
        /// </summary>
        public const string LSUEFFT = "LSUEFFT";

        /// <summary>
        /// LSPID.
        /// </summary>
        public const string LSPID = "LSPID";

        /// <summary>
        /// LSVERS.
        /// </summary>
        public const string LSVERS = "LSVERS";

        /// <summary>
        /// LSUSER.
        /// </summary>
        public const string LSUSER = "LSUSER";

        /// <summary>
        /// LSMKEY.
        /// </summary>
        public const string LSMKEY = "LSMKEY";

        /// <summary>
        /// LSUTIME.
        /// </summary>
        public const string LSUTIME = "LSUTIME";

        /// <summary>
        /// LSWUTIME.
        /// </summary>
        public const string LSWUTIME = "LSWUTIME";

        /// <summary>
        /// LSN1FU.
        /// </summary>
        public const string LSN1FU = "LSN1FU";

        /// <summary>
        /// LSS1FU.
        /// </summary>
        public const string LSS1FU = "LSS1FU";
    }

    /// <inheritdoc />
    public override string TableName => "F41081";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LSLOTGRP", "LSLOTGRP", JdeDataType.String, 60, true, true),
        new JdeField("LSMCU", "LSMCU", JdeDataType.String, 24, true, true),
        new JdeField("LSDCTO", "LSDCTO", JdeDataType.String, 4, true, true),
        new JdeField("LSLOTS", "LSLOTS", JdeDataType.String, 2, true, true),
        new JdeField("LSUEFFF", "LSUEFFF", JdeDataType.Date),
        new JdeField("LSUEFFT", "LSUEFFT", JdeDataType.Date),
        new JdeField("LSPID", "LSPID", JdeDataType.String, 20),
        new JdeField("LSVERS", "LSVERS", JdeDataType.String, 20),
        new JdeField("LSUSER", "LSUSER", JdeDataType.String, 20),
        new JdeField("LSMKEY", "LSMKEY", JdeDataType.String, 30),
        new JdeField("LSUTIME", "LSUTIME", JdeDataType.Date),
        new JdeField("LSWUTIME", "LSWUTIME", JdeDataType.Date),
        new JdeField("LSN1FU", "LSN1FU", JdeDataType.Numeric),
        new JdeField("LSS1FU", "LSS1FU", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41081_0", "Primary Key on LSLOTGRP, LSMCU, LSDCTO, LSLOTS", new[] { "LSLOTGRP", "LSMCU", "LSDCTO", "LSLOTS" }, isUnique: true, isPrimaryKey: true)
    };
}
