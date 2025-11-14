using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F95701 - .
/// </summary>
public class F95701 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RRRULENAME.
        /// </summary>
        public const string RRRULENAME = "RRRULENAME";

        /// <summary>
        /// RRRULEDESC.
        /// </summary>
        public const string RRRULEDESC = "RRRULEDESC";

        /// <summary>
        /// RRRULESEQN.
        /// </summary>
        public const string RRRULESEQN = "RRRULESEQN";

        /// <summary>
        /// RRRULEOP1.
        /// </summary>
        public const string RRRULEOP1 = "RRRULEOP1";

        /// <summary>
        /// RRRULEOP2.
        /// </summary>
        public const string RRRULEOP2 = "RRRULEOP2";

        /// <summary>
        /// RRRULERELOP.
        /// </summary>
        public const string RRRULERELOP = "RRRULERELOP";

        /// <summary>
        /// RRRULEBOLOP.
        /// </summary>
        public const string RRRULEBOLOP = "RRRULEBOLOP";

        /// <summary>
        /// RRRULEVOP.
        /// </summary>
        public const string RRRULEVOP = "RRRULEVOP";

        /// <summary>
        /// RRRULEREPVAL.
        /// </summary>
        public const string RRRULEREPVAL = "RRRULEREPVAL";

        /// <summary>
        /// RRRULEREPPOS.
        /// </summary>
        public const string RRRULEREPPOS = "RRRULEREPPOS";

        /// <summary>
        /// RRRULESKIPTO.
        /// </summary>
        public const string RRRULESKIPTO = "RRRULESKIPTO";

        /// <summary>
        /// RRFUTUSE01.
        /// </summary>
        public const string RRFUTUSE01 = "RRFUTUSE01";

        /// <summary>
        /// RRFUTUSE03.
        /// </summary>
        public const string RRFUTUSE03 = "RRFUTUSE03";

        /// <summary>
        /// RRFUTUSE04.
        /// </summary>
        public const string RRFUTUSE04 = "RRFUTUSE04";

        /// <summary>
        /// RRFUTUSE011.
        /// </summary>
        public const string RRFUTUSE011 = "RRFUTUSE011";

        /// <summary>
        /// RRUPMJ.
        /// </summary>
        public const string RRUPMJ = "RRUPMJ";

        /// <summary>
        /// RRUPMT.
        /// </summary>
        public const string RRUPMT = "RRUPMT";

        /// <summary>
        /// RRPID.
        /// </summary>
        public const string RRPID = "RRPID";

        /// <summary>
        /// RRUSER.
        /// </summary>
        public const string RRUSER = "RRUSER";

        /// <summary>
        /// RRJOBN.
        /// </summary>
        public const string RRJOBN = "RRJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F95701";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RRRULENAME", "RRRULENAME", JdeDataType.String, 20, true, true),
        new JdeField("RRRULEDESC", "RRRULEDESC", JdeDataType.String, 60),
        new JdeField("RRRULESEQN", "RRRULESEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("RRRULEOP1", "RRRULEOP1", JdeDataType.Numeric),
        new JdeField("RRRULEOP2", "RRRULEOP2", JdeDataType.Numeric),
        new JdeField("RRRULERELOP", "RRRULERELOP", JdeDataType.Numeric),
        new JdeField("RRRULEBOLOP", "RRRULEBOLOP", JdeDataType.Numeric),
        new JdeField("RRRULEVOP", "RRRULEVOP", JdeDataType.Numeric),
        new JdeField("RRRULEREPVAL", "RRRULEREPVAL", JdeDataType.Numeric),
        new JdeField("RRRULEREPPOS", "RRRULEREPPOS", JdeDataType.Numeric),
        new JdeField("RRRULESKIPTO", "RRRULESKIPTO", JdeDataType.String, 2),
        new JdeField("RRFUTUSE01", "RRFUTUSE01", JdeDataType.String, 2),
        new JdeField("RRFUTUSE03", "RRFUTUSE03", JdeDataType.String, 40),
        new JdeField("RRFUTUSE04", "RRFUTUSE04", JdeDataType.Numeric),
        new JdeField("RRFUTUSE011", "RRFUTUSE011", JdeDataType.Numeric),
        new JdeField("RRUPMJ", "RRUPMJ", JdeDataType.Numeric),
        new JdeField("RRUPMT", "RRUPMT", JdeDataType.Numeric),
        new JdeField("RRPID", "RRPID", JdeDataType.String, 20),
        new JdeField("RRUSER", "RRUSER", JdeDataType.String, 20),
        new JdeField("RRJOBN", "RRJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F95701_0", "Primary Key on RRRULENAME, RRRULESEQN", new[] { "RRRULENAME", "RRRULESEQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F95701_2", "Index on RRRULENAME", new[] { "RRRULENAME" })
    };
}
