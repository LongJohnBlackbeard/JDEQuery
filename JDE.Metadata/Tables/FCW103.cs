using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW103 - .
/// </summary>
public class FCW103 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WMJOBS.
        /// </summary>
        public const string WMJOBS = "WMJOBS";

        /// <summary>
        /// WMDOCO.
        /// </summary>
        public const string WMDOCO = "WMDOCO";

        /// <summary>
        /// WMC9MCU.
        /// </summary>
        public const string WMC9MCU = "WMC9MCU";

        /// <summary>
        /// WMC9ITM.
        /// </summary>
        public const string WMC9ITM = "WMC9ITM";

        /// <summary>
        /// WMLOCN.
        /// </summary>
        public const string WMLOCN = "WMLOCN";

        /// <summary>
        /// WMLOTN.
        /// </summary>
        public const string WMLOTN = "WMLOTN";

        /// <summary>
        /// WMSCRP.
        /// </summary>
        public const string WMSCRP = "WMSCRP";

        /// <summary>
        /// WMC9UORG.
        /// </summary>
        public const string WMC9UORG = "WMC9UORG";

        /// <summary>
        /// WMC9TRQT.
        /// </summary>
        public const string WMC9TRQT = "WMC9TRQT";

        /// <summary>
        /// WMC9QTY.
        /// </summary>
        public const string WMC9QTY = "WMC9QTY";

        /// <summary>
        /// WMC9QTY1.
        /// </summary>
        public const string WMC9QTY1 = "WMC9QTY1";

        /// <summary>
        /// WMC9QTY2.
        /// </summary>
        public const string WMC9QTY2 = "WMC9QTY2";
    }

    /// <inheritdoc />
    public override string TableName => "FCW103";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WMJOBS", "WMJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WMDOCO", "WMDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WMC9MCU", "WMC9MCU", JdeDataType.String, 24, true, true),
        new JdeField("WMC9ITM", "WMC9ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WMLOCN", "WMLOCN", JdeDataType.String, 40, true, true),
        new JdeField("WMLOTN", "WMLOTN", JdeDataType.String, 60, true, true),
        new JdeField("WMSCRP", "WMSCRP", JdeDataType.Numeric, null, true, true),
        new JdeField("WMC9UORG", "WMC9UORG", JdeDataType.Numeric),
        new JdeField("WMC9TRQT", "WMC9TRQT", JdeDataType.Numeric),
        new JdeField("WMC9QTY", "WMC9QTY", JdeDataType.Numeric),
        new JdeField("WMC9QTY1", "WMC9QTY1", JdeDataType.Numeric),
        new JdeField("WMC9QTY2", "WMC9QTY2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW103_0", "Primary Key on WMJOBS, WMDOCO, WMC9MCU, WMC9ITM, WMLOCN, WMLOTN, WMSCRP", new[] { "WMJOBS", "WMDOCO", "WMC9MCU", "WMC9ITM", "WMLOCN", "WMLOTN", "WMSCRP" }, isUnique: true, isPrimaryKey: true)
    };
}
