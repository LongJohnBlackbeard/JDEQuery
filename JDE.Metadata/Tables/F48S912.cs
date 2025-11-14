using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48S912 - .
/// </summary>
public class F48S912 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// W6AID.
        /// </summary>
        public const string W6AID = "W6AID";

        /// <summary>
        /// W6ICU.
        /// </summary>
        public const string W6ICU = "W6ICU";

        /// <summary>
        /// W6SBL.
        /// </summary>
        public const string W6SBL = "W6SBL";

        /// <summary>
        /// W6SBLT.
        /// </summary>
        public const string W6SBLT = "W6SBLT";

        /// <summary>
        /// W6LT.
        /// </summary>
        public const string W6LT = "W6LT";

        /// <summary>
        /// W6DOC.
        /// </summary>
        public const string W6DOC = "W6DOC";

        /// <summary>
        /// W6DCT.
        /// </summary>
        public const string W6DCT = "W6DCT";

        /// <summary>
        /// W6KCO.
        /// </summary>
        public const string W6KCO = "W6KCO";

        /// <summary>
        /// W6SFX.
        /// </summary>
        public const string W6SFX = "W6SFX";

        /// <summary>
        /// W6JELN.
        /// </summary>
        public const string W6JELN = "W6JELN";

        /// <summary>
        /// W6DGL.
        /// </summary>
        public const string W6DGL = "W6DGL";

        /// <summary>
        /// W6BCI.
        /// </summary>
        public const string W6BCI = "W6BCI";

        /// <summary>
        /// W6PRSQ.
        /// </summary>
        public const string W6PRSQ = "W6PRSQ";

        /// <summary>
        /// W6SBSQ.
        /// </summary>
        public const string W6SBSQ = "W6SBSQ";

        /// <summary>
        /// W6SCSQ.
        /// </summary>
        public const string W6SCSQ = "W6SCSQ";

        /// <summary>
        /// W6U.
        /// </summary>
        public const string W6U = "W6U";

        /// <summary>
        /// W6AA.
        /// </summary>
        public const string W6AA = "W6AA";

        /// <summary>
        /// W6CLNK.
        /// </summary>
        public const string W6CLNK = "W6CLNK";

        /// <summary>
        /// W6CCOD.
        /// </summary>
        public const string W6CCOD = "W6CCOD";

        /// <summary>
        /// W6DGJ.
        /// </summary>
        public const string W6DGJ = "W6DGJ";

        /// <summary>
        /// W6MCU.
        /// </summary>
        public const string W6MCU = "W6MCU";

        /// <summary>
        /// W6OBJ.
        /// </summary>
        public const string W6OBJ = "W6OBJ";

        /// <summary>
        /// W6SUB.
        /// </summary>
        public const string W6SUB = "W6SUB";

        /// <summary>
        /// W6SLNK.
        /// </summary>
        public const string W6SLNK = "W6SLNK";

        /// <summary>
        /// W6JOBN.
        /// </summary>
        public const string W6JOBN = "W6JOBN";

        /// <summary>
        /// W6PID.
        /// </summary>
        public const string W6PID = "W6PID";

        /// <summary>
        /// W6USER.
        /// </summary>
        public const string W6USER = "W6USER";

        /// <summary>
        /// W6UPMJ.
        /// </summary>
        public const string W6UPMJ = "W6UPMJ";

        /// <summary>
        /// W6UPMT.
        /// </summary>
        public const string W6UPMT = "W6UPMT";

        /// <summary>
        /// W6UKID.
        /// </summary>
        public const string W6UKID = "W6UKID";

        /// <summary>
        /// W6ANUM.
        /// </summary>
        public const string W6ANUM = "W6ANUM";
    }

    /// <inheritdoc />
    public override string TableName => "F48S912";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("W6AID", "W6AID", JdeDataType.String, 16, true, true),
        new JdeField("W6ICU", "W6ICU", JdeDataType.Numeric),
        new JdeField("W6SBL", "W6SBL", JdeDataType.String, 16),
        new JdeField("W6SBLT", "W6SBLT", JdeDataType.String, 2),
        new JdeField("W6LT", "W6LT", JdeDataType.String, 4, true, true),
        new JdeField("W6DOC", "W6DOC", JdeDataType.Numeric),
        new JdeField("W6DCT", "W6DCT", JdeDataType.String, 4, true, true),
        new JdeField("W6KCO", "W6KCO", JdeDataType.String, 10),
        new JdeField("W6SFX", "W6SFX", JdeDataType.String, 6),
        new JdeField("W6JELN", "W6JELN", JdeDataType.Numeric),
        new JdeField("W6DGL", "W6DGL", JdeDataType.Numeric, null, true, true),
        new JdeField("W6BCI", "W6BCI", JdeDataType.Numeric, null, true, true),
        new JdeField("W6PRSQ", "W6PRSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("W6SBSQ", "W6SBSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("W6SCSQ", "W6SCSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("W6U", "W6U", JdeDataType.Numeric),
        new JdeField("W6AA", "W6AA", JdeDataType.Numeric),
        new JdeField("W6CLNK", "W6CLNK", JdeDataType.Numeric),
        new JdeField("W6CCOD", "W6CCOD", JdeDataType.String, 10, true, true),
        new JdeField("W6DGJ", "W6DGJ", JdeDataType.Numeric),
        new JdeField("W6MCU", "W6MCU", JdeDataType.String, 24),
        new JdeField("W6OBJ", "W6OBJ", JdeDataType.String, 12),
        new JdeField("W6SUB", "W6SUB", JdeDataType.String, 16),
        new JdeField("W6SLNK", "W6SLNK", JdeDataType.Numeric),
        new JdeField("W6JOBN", "W6JOBN", JdeDataType.String, 20),
        new JdeField("W6PID", "W6PID", JdeDataType.String, 20),
        new JdeField("W6USER", "W6USER", JdeDataType.String, 20),
        new JdeField("W6UPMJ", "W6UPMJ", JdeDataType.Numeric),
        new JdeField("W6UPMT", "W6UPMT", JdeDataType.Numeric),
        new JdeField("W6UKID", "W6UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("W6ANUM", "W6ANUM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48S912_0", "Primary Key on W6AID, W6BCI, W6DGL, W6PRSQ, W6SBSQ, W6SCSQ, W6CCOD, W6DCT, W6LT, W6UKID", new[] { "W6AID", "W6BCI", "W6DGL", "W6PRSQ", "W6SBSQ", "W6SCSQ", "W6CCOD", "W6DCT", "W6LT", "W6UKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48S912_2", "Index on W6BCI, W6SBSQ, W6SCSQ, W6CCOD, W6DCT", new[] { "W6BCI", "W6SBSQ", "W6SCSQ", "W6CCOD", "W6DCT" }),
        new JdeIndex("F48S912_3", "Index on W6KCO, W6DCT, W6DOC, SYS_NC00032$, W6JELN, W6BCI, W6PRSQ, W6SBSQ, W6SCSQ", new[] { "W6KCO", "W6DCT", "W6DOC", "SYS_NC00032$", "W6JELN", "W6BCI", "W6PRSQ", "W6SBSQ", "W6SCSQ" })
    };
}
