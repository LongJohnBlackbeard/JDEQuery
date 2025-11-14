using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7430018 - .
/// </summary>
public class F7430018 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TIKCO.
        /// </summary>
        public const string TIKCO = "TIKCO";

        /// <summary>
        /// TIDCT.
        /// </summary>
        public const string TIDCT = "TIDCT";

        /// <summary>
        /// TIDOC.
        /// </summary>
        public const string TIDOC = "TIDOC";

        /// <summary>
        /// TISFX.
        /// </summary>
        public const string TISFX = "TISFX";

        /// <summary>
        /// TIK74TAXC.
        /// </summary>
        public const string TIK74TAXC = "TIK74TAXC";

        /// <summary>
        /// TITXR1.
        /// </summary>
        public const string TITXR1 = "TITXR1";

        /// <summary>
        /// TICO.
        /// </summary>
        public const string TICO = "TICO";

        /// <summary>
        /// TICRCD.
        /// </summary>
        public const string TICRCD = "TICRCD";

        /// <summary>
        /// TIK74TAXD.
        /// </summary>
        public const string TIK74TAXD = "TIK74TAXD";

        /// <summary>
        /// TIK74TAXF.
        /// </summary>
        public const string TIK74TAXF = "TIK74TAXF";

        /// <summary>
        /// TIUSER.
        /// </summary>
        public const string TIUSER = "TIUSER";

        /// <summary>
        /// TIPID.
        /// </summary>
        public const string TIPID = "TIPID";

        /// <summary>
        /// TIJOBN.
        /// </summary>
        public const string TIJOBN = "TIJOBN";

        /// <summary>
        /// TIUPMJ.
        /// </summary>
        public const string TIUPMJ = "TIUPMJ";

        /// <summary>
        /// TIUPMT.
        /// </summary>
        public const string TIUPMT = "TIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F7430018";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TIKCO", "TIKCO", JdeDataType.String, 10, true, true),
        new JdeField("TIDCT", "TIDCT", JdeDataType.String, 4, true, true),
        new JdeField("TIDOC", "TIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TISFX", "TISFX", JdeDataType.String, 6, true, true),
        new JdeField("TIK74TAXC", "TIK74TAXC", JdeDataType.String, 20, true, true),
        new JdeField("TITXR1", "TITXR1", JdeDataType.Numeric),
        new JdeField("TICO", "TICO", JdeDataType.String, 10),
        new JdeField("TICRCD", "TICRCD", JdeDataType.String, 6),
        new JdeField("TIK74TAXD", "TIK74TAXD", JdeDataType.Numeric),
        new JdeField("TIK74TAXF", "TIK74TAXF", JdeDataType.Numeric),
        new JdeField("TIUSER", "TIUSER", JdeDataType.String, 20),
        new JdeField("TIPID", "TIPID", JdeDataType.String, 20),
        new JdeField("TIJOBN", "TIJOBN", JdeDataType.String, 20),
        new JdeField("TIUPMJ", "TIUPMJ", JdeDataType.Numeric),
        new JdeField("TIUPMT", "TIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7430018_0", "Primary Key on TIKCO, TIDCT, TIDOC, TISFX, TIK74TAXC", new[] { "TIKCO", "TIDCT", "TIDOC", "TISFX", "TIK74TAXC" }, isUnique: true, isPrimaryKey: true)
    };
}
