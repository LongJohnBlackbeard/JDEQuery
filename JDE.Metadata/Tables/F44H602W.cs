using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H602W - .
/// </summary>
public class F44H602W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TSJOBS.
        /// </summary>
        public const string TSJOBS = "TSJOBS";

        /// <summary>
        /// TSHBAREA.
        /// </summary>
        public const string TSHBAREA = "TSHBAREA";

        /// <summary>
        /// TSHBPLAN.
        /// </summary>
        public const string TSHBPLAN = "TSHBPLAN";

        /// <summary>
        /// TSHBMCUS.
        /// </summary>
        public const string TSHBMCUS = "TSHBMCUS";

        /// <summary>
        /// TSCPHASE.
        /// </summary>
        public const string TSCPHASE = "TSCPHASE";

        /// <summary>
        /// TSHBELEV.
        /// </summary>
        public const string TSHBELEV = "TSHBELEV";

        /// <summary>
        /// TSSWING.
        /// </summary>
        public const string TSSWING = "TSSWING";

        /// <summary>
        /// TSSUB.
        /// </summary>
        public const string TSSUB = "TSSUB";

        /// <summary>
        /// TSOBJ.
        /// </summary>
        public const string TSOBJ = "TSOBJ";

        /// <summary>
        /// TSOPTION.
        /// </summary>
        public const string TSOPTION = "TSOPTION";

        /// <summary>
        /// TSITM.
        /// </summary>
        public const string TSITM = "TSITM";

        /// <summary>
        /// TSETF.
        /// </summary>
        public const string TSETF = "TSETF";

        /// <summary>
        /// TSSUBITEM.
        /// </summary>
        public const string TSSUBITEM = "TSSUBITEM";

        /// <summary>
        /// TSLITM.
        /// </summary>
        public const string TSLITM = "TSLITM";

        /// <summary>
        /// TSAITM.
        /// </summary>
        public const string TSAITM = "TSAITM";

        /// <summary>
        /// TSUORG.
        /// </summary>
        public const string TSUORG = "TSUORG";

        /// <summary>
        /// TSUOM.
        /// </summary>
        public const string TSUOM = "TSUOM";

        /// <summary>
        /// TSUSER.
        /// </summary>
        public const string TSUSER = "TSUSER";

        /// <summary>
        /// TSUPMJ.
        /// </summary>
        public const string TSUPMJ = "TSUPMJ";

        /// <summary>
        /// TSUPMT.
        /// </summary>
        public const string TSUPMT = "TSUPMT";

        /// <summary>
        /// TSHBST1.
        /// </summary>
        public const string TSHBST1 = "TSHBST1";

        /// <summary>
        /// TSHBST2.
        /// </summary>
        public const string TSHBST2 = "TSHBST2";

        /// <summary>
        /// TSHBST3.
        /// </summary>
        public const string TSHBST3 = "TSHBST3";

        /// <summary>
        /// TSHBST4.
        /// </summary>
        public const string TSHBST4 = "TSHBST4";

        /// <summary>
        /// TSHBST5.
        /// </summary>
        public const string TSHBST5 = "TSHBST5";
    }

    /// <inheritdoc />
    public override string TableName => "F44H602W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TSJOBS", "TSJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TSHBAREA", "TSHBAREA", JdeDataType.String, 6, true, true),
        new JdeField("TSHBPLAN", "TSHBPLAN", JdeDataType.String, 8, true, true),
        new JdeField("TSHBMCUS", "TSHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("TSCPHASE", "TSCPHASE", JdeDataType.String, 6, true, true),
        new JdeField("TSHBELEV", "TSHBELEV", JdeDataType.String, 6, true, true),
        new JdeField("TSSWING", "TSSWING", JdeDataType.String, 2, true, true),
        new JdeField("TSSUB", "TSSUB", JdeDataType.String, 16, true, true),
        new JdeField("TSOBJ", "TSOBJ", JdeDataType.String, 12, true, true),
        new JdeField("TSOPTION", "TSOPTION", JdeDataType.String, 16, true, true),
        new JdeField("TSITM", "TSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TSETF", "TSETF", JdeDataType.String, 2, true, true),
        new JdeField("TSSUBITEM", "TSSUBITEM", JdeDataType.String, 50, true, true),
        new JdeField("TSLITM", "TSLITM", JdeDataType.String, 50),
        new JdeField("TSAITM", "TSAITM", JdeDataType.String, 50),
        new JdeField("TSUORG", "TSUORG", JdeDataType.Numeric),
        new JdeField("TSUOM", "TSUOM", JdeDataType.String, 4),
        new JdeField("TSUSER", "TSUSER", JdeDataType.String, 20),
        new JdeField("TSUPMJ", "TSUPMJ", JdeDataType.Numeric),
        new JdeField("TSUPMT", "TSUPMT", JdeDataType.Numeric),
        new JdeField("TSHBST1", "TSHBST1", JdeDataType.String, 2),
        new JdeField("TSHBST2", "TSHBST2", JdeDataType.String, 2),
        new JdeField("TSHBST3", "TSHBST3", JdeDataType.String, 2),
        new JdeField("TSHBST4", "TSHBST4", JdeDataType.String, 2),
        new JdeField("TSHBST5", "TSHBST5", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H602W_0", "Primary Key on TSJOBS, TSHBAREA, TSHBPLAN, TSHBMCUS, TSCPHASE, TSHBELEV, TSSWING, TSOPTION, TSSUB, TSOBJ, TSITM, TSETF, TSSUBITEM", new[] { "TSJOBS", "TSHBAREA", "TSHBPLAN", "TSHBMCUS", "TSCPHASE", "TSHBELEV", "TSSWING", "TSOPTION", "TSSUB", "TSOBJ", "TSITM", "TSETF", "TSSUBITEM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H602W_2", "Index on TSLITM, TSJOBS, TSHBAREA, TSHBMCUS, TSCPHASE, TSHBPLAN, TSHBELEV, TSSWING, TSSUB, TSOBJ, TSOPTION", new[] { "TSLITM", "TSJOBS", "TSHBAREA", "TSHBMCUS", "TSCPHASE", "TSHBPLAN", "TSHBELEV", "TSSWING", "TSSUB", "TSOBJ", "TSOPTION" })
    };
}
