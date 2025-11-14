using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H712 - .
/// </summary>
public class F44H712 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STMCU.
        /// </summary>
        public const string STMCU = "STMCU";

        /// <summary>
        /// STOBJ.
        /// </summary>
        public const string STOBJ = "STOBJ";

        /// <summary>
        /// STSUB.
        /// </summary>
        public const string STSUB = "STSUB";

        /// <summary>
        /// STOPTN.
        /// </summary>
        public const string STOPTN = "STOPTN";

        /// <summary>
        /// STAN8.
        /// </summary>
        public const string STAN8 = "STAN8";

        /// <summary>
        /// STLITM.
        /// </summary>
        public const string STLITM = "STLITM";

        /// <summary>
        /// STSEQ.
        /// </summary>
        public const string STSEQ = "STSEQ";

        /// <summary>
        /// STMCUS.
        /// </summary>
        public const string STMCUS = "STMCUS";

        /// <summary>
        /// STCPHASE.
        /// </summary>
        public const string STCPHASE = "STCPHASE";

        /// <summary>
        /// STPL.
        /// </summary>
        public const string STPL = "STPL";

        /// <summary>
        /// STELEV.
        /// </summary>
        public const string STELEV = "STELEV";

        /// <summary>
        /// STSWG.
        /// </summary>
        public const string STSWG = "STSWG";

        /// <summary>
        /// STUORG.
        /// </summary>
        public const string STUORG = "STUORG";

        /// <summary>
        /// STMCUTJ.
        /// </summary>
        public const string STMCUTJ = "STMCUTJ";

        /// <summary>
        /// STCRTU.
        /// </summary>
        public const string STCRTU = "STCRTU";

        /// <summary>
        /// STCRTJ.
        /// </summary>
        public const string STCRTJ = "STCRTJ";

        /// <summary>
        /// STCRTT.
        /// </summary>
        public const string STCRTT = "STCRTT";

        /// <summary>
        /// STWRKSTNID.
        /// </summary>
        public const string STWRKSTNID = "STWRKSTNID";

        /// <summary>
        /// STJPID.
        /// </summary>
        public const string STJPID = "STJPID";

        /// <summary>
        /// STUPMB.
        /// </summary>
        public const string STUPMB = "STUPMB";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H712";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STMCU", "STMCU", JdeDataType.String, 24, true, true),
        new JdeField("STOBJ", "STOBJ", JdeDataType.String, 12, true, true),
        new JdeField("STSUB", "STSUB", JdeDataType.String, 16, true, true),
        new JdeField("STOPTN", "STOPTN", JdeDataType.String, 16, true, true),
        new JdeField("STAN8", "STAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("STLITM", "STLITM", JdeDataType.String, 50, true, true),
        new JdeField("STSEQ", "STSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("STMCUS", "STMCUS", JdeDataType.String, 24, true, true),
        new JdeField("STCPHASE", "STCPHASE", JdeDataType.String, 6, true, true),
        new JdeField("STPL", "STPL", JdeDataType.String, 8, true, true),
        new JdeField("STELEV", "STELEV", JdeDataType.String, 6, true, true),
        new JdeField("STSWG", "STSWG", JdeDataType.String, 2),
        new JdeField("STUORG", "STUORG", JdeDataType.Numeric),
        new JdeField("STMCUTJ", "STMCUTJ", JdeDataType.String, 24),
        new JdeField("STCRTU", "STCRTU", JdeDataType.String, 20),
        new JdeField("STCRTJ", "STCRTJ", JdeDataType.Numeric),
        new JdeField("STCRTT", "STCRTT", JdeDataType.Numeric),
        new JdeField("STWRKSTNID", "STWRKSTNID", JdeDataType.String, 20),
        new JdeField("STJPID", "STJPID", JdeDataType.String, 20),
        new JdeField("STUPMB", "STUPMB", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H712_0", "Primary Key on STMCU, STOBJ, STSUB, STOPTN, STAN8, STLITM, STSEQ, STMCUS, STCPHASE, STPL, STELEV", new[] { "STMCU", "STOBJ", "STSUB", "STOPTN", "STAN8", "STLITM", "STSEQ", "STMCUS", "STCPHASE", "STPL", "STELEV" }, isUnique: true, isPrimaryKey: true)
    };
}
