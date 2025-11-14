using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40205 - .
/// </summary>
public class F40205 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LFLNTY.
        /// </summary>
        public const string LFLNTY = "LFLNTY";

        /// <summary>
        /// LFLNDS.
        /// </summary>
        public const string LFLNDS = "LFLNDS";

        /// <summary>
        /// LFLND2.
        /// </summary>
        public const string LFLND2 = "LFLND2";

        /// <summary>
        /// LFGLI.
        /// </summary>
        public const string LFGLI = "LFGLI";

        /// <summary>
        /// LFIVI.
        /// </summary>
        public const string LFIVI = "LFIVI";

        /// <summary>
        /// LFARI.
        /// </summary>
        public const string LFARI = "LFARI";

        /// <summary>
        /// LFAPI.
        /// </summary>
        public const string LFAPI = "LFAPI";

        /// <summary>
        /// LFRSGN.
        /// </summary>
        public const string LFRSGN = "LFRSGN";

        /// <summary>
        /// LFTXYN.
        /// </summary>
        public const string LFTXYN = "LFTXYN";

        /// <summary>
        /// LFPRFT.
        /// </summary>
        public const string LFPRFT = "LFPRFT";

        /// <summary>
        /// LFCDSC.
        /// </summary>
        public const string LFCDSC = "LFCDSC";

        /// <summary>
        /// LFTX01.
        /// </summary>
        public const string LFTX01 = "LFTX01";

        /// <summary>
        /// LFTX02.
        /// </summary>
        public const string LFTX02 = "LFTX02";

        /// <summary>
        /// LFGLC.
        /// </summary>
        public const string LFGLC = "LFGLC";

        /// <summary>
        /// LFPDC1.
        /// </summary>
        public const string LFPDC1 = "LFPDC1";

        /// <summary>
        /// LFPDC2.
        /// </summary>
        public const string LFPDC2 = "LFPDC2";

        /// <summary>
        /// LFPDC3.
        /// </summary>
        public const string LFPDC3 = "LFPDC3";

        /// <summary>
        /// LFPDC4.
        /// </summary>
        public const string LFPDC4 = "LFPDC4";

        /// <summary>
        /// LFIDC1.
        /// </summary>
        public const string LFIDC1 = "LFIDC1";

        /// <summary>
        /// LFIDC2.
        /// </summary>
        public const string LFIDC2 = "LFIDC2";

        /// <summary>
        /// LFIDC3.
        /// </summary>
        public const string LFIDC3 = "LFIDC3";

        /// <summary>
        /// LFIDC4.
        /// </summary>
        public const string LFIDC4 = "LFIDC4";

        /// <summary>
        /// LFCSJ.
        /// </summary>
        public const string LFCSJ = "LFCSJ";

        /// <summary>
        /// LFDCTO.
        /// </summary>
        public const string LFDCTO = "LFDCTO";

        /// <summary>
        /// LFART.
        /// </summary>
        public const string LFART = "LFART";

        /// <summary>
        /// LFAFT.
        /// </summary>
        public const string LFAFT = "LFAFT";

        /// <summary>
        /// LFGWO.
        /// </summary>
        public const string LFGWO = "LFGWO";

        /// <summary>
        /// LFEXVR.
        /// </summary>
        public const string LFEXVR = "LFEXVR";

        /// <summary>
        /// LFCMI.
        /// </summary>
        public const string LFCMI = "LFCMI";

        /// <summary>
        /// LFPRRQ.
        /// </summary>
        public const string LFPRRQ = "LFPRRQ";

        /// <summary>
        /// LFEV01.
        /// </summary>
        public const string LFEV01 = "LFEV01";

        /// <summary>
        /// LFEV02.
        /// </summary>
        public const string LFEV02 = "LFEV02";

        /// <summary>
        /// LFEV03.
        /// </summary>
        public const string LFEV03 = "LFEV03";

        /// <summary>
        /// LFEV04.
        /// </summary>
        public const string LFEV04 = "LFEV04";

        /// <summary>
        /// LFEV05.
        /// </summary>
        public const string LFEV05 = "LFEV05";

        /// <summary>
        /// LFNEWR.
        /// </summary>
        public const string LFNEWR = "LFNEWR";

        /// <summary>
        /// LFSRUF.
        /// </summary>
        public const string LFSRUF = "LFSRUF";

        /// <summary>
        /// LFNBRU.
        /// </summary>
        public const string LFNBRU = "LFNBRU";
    }

    /// <inheritdoc />
    public override string TableName => "F40205";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LFLNTY", "LFLNTY", JdeDataType.String, 4, true, true),
        new JdeField("LFLNDS", "LFLNDS", JdeDataType.String, 60),
        new JdeField("LFLND2", "LFLND2", JdeDataType.String, 60),
        new JdeField("LFGLI", "LFGLI", JdeDataType.String, 2),
        new JdeField("LFIVI", "LFIVI", JdeDataType.String, 2),
        new JdeField("LFARI", "LFARI", JdeDataType.String, 2),
        new JdeField("LFAPI", "LFAPI", JdeDataType.String, 2),
        new JdeField("LFRSGN", "LFRSGN", JdeDataType.String, 2),
        new JdeField("LFTXYN", "LFTXYN", JdeDataType.String, 2),
        new JdeField("LFPRFT", "LFPRFT", JdeDataType.String, 2),
        new JdeField("LFCDSC", "LFCDSC", JdeDataType.String, 2),
        new JdeField("LFTX01", "LFTX01", JdeDataType.String, 2),
        new JdeField("LFTX02", "LFTX02", JdeDataType.String, 2),
        new JdeField("LFGLC", "LFGLC", JdeDataType.String, 8),
        new JdeField("LFPDC1", "LFPDC1", JdeDataType.String, 2),
        new JdeField("LFPDC2", "LFPDC2", JdeDataType.String, 2),
        new JdeField("LFPDC3", "LFPDC3", JdeDataType.String, 2),
        new JdeField("LFPDC4", "LFPDC4", JdeDataType.String, 2),
        new JdeField("LFIDC1", "LFIDC1", JdeDataType.String, 2),
        new JdeField("LFIDC2", "LFIDC2", JdeDataType.String, 2),
        new JdeField("LFIDC3", "LFIDC3", JdeDataType.String, 2),
        new JdeField("LFIDC4", "LFIDC4", JdeDataType.String, 2),
        new JdeField("LFCSJ", "LFCSJ", JdeDataType.String, 2),
        new JdeField("LFDCTO", "LFDCTO", JdeDataType.String, 4),
        new JdeField("LFART", "LFART", JdeDataType.String, 2),
        new JdeField("LFAFT", "LFAFT", JdeDataType.String, 2),
        new JdeField("LFGWO", "LFGWO", JdeDataType.String, 2),
        new JdeField("LFEXVR", "LFEXVR", JdeDataType.String, 2),
        new JdeField("LFCMI", "LFCMI", JdeDataType.String, 2),
        new JdeField("LFPRRQ", "LFPRRQ", JdeDataType.String, 2),
        new JdeField("LFEV01", "LFEV01", JdeDataType.String, 2),
        new JdeField("LFEV02", "LFEV02", JdeDataType.String, 2),
        new JdeField("LFEV03", "LFEV03", JdeDataType.String, 2),
        new JdeField("LFEV04", "LFEV04", JdeDataType.String, 2),
        new JdeField("LFEV05", "LFEV05", JdeDataType.String, 2),
        new JdeField("LFNEWR", "LFNEWR", JdeDataType.String, 2),
        new JdeField("LFSRUF", "LFSRUF", JdeDataType.String, 2),
        new JdeField("LFNBRU", "LFNBRU", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40205_0", "Primary Key on LFLNTY", new[] { "LFLNTY" }, isUnique: true, isPrimaryKey: true)
    };
}
