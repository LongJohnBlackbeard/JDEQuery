using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00142 - .
/// </summary>
public class F00142 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// L4DDRL.
        /// </summary>
        public const string L4DDRL = "L4DDRL";

        /// <summary>
        /// L4DL01.
        /// </summary>
        public const string L4DL01 = "L4DL01";

        /// <summary>
        /// L4DABS.
        /// </summary>
        public const string L4DABS = "L4DABS";

        /// <summary>
        /// L4DADD.
        /// </summary>
        public const string L4DADD = "L4DADD";

        /// <summary>
        /// L4DYFX.
        /// </summary>
        public const string L4DYFX = "L4DYFX";

        /// <summary>
        /// L4MADD.
        /// </summary>
        public const string L4MADD = "L4MADD";

        /// <summary>
        /// L4CALN.
        /// </summary>
        public const string L4CALN = "L4CALN";

        /// <summary>
        /// L4WKDY.
        /// </summary>
        public const string L4WKDY = "L4WKDY";

        /// <summary>
        /// L4DSTRPAMT.
        /// </summary>
        public const string L4DSTRPAMT = "L4DSTRPAMT";

        /// <summary>
        /// L4DSTRDTE.
        /// </summary>
        public const string L4DSTRDTE = "L4DSTRDTE";

        /// <summary>
        /// L4DLVPRC.
        /// </summary>
        public const string L4DLVPRC = "L4DLVPRC";

        /// <summary>
        /// L4ADVPMNT.
        /// </summary>
        public const string L4ADVPMNT = "L4ADVPMNT";

        /// <summary>
        /// L4BSDON.
        /// </summary>
        public const string L4BSDON = "L4BSDON";

        /// <summary>
        /// L4URAT.
        /// </summary>
        public const string L4URAT = "L4URAT";

        /// <summary>
        /// L4URCD.
        /// </summary>
        public const string L4URCD = "L4URCD";

        /// <summary>
        /// L4URDT.
        /// </summary>
        public const string L4URDT = "L4URDT";

        /// <summary>
        /// L4URAB.
        /// </summary>
        public const string L4URAB = "L4URAB";

        /// <summary>
        /// L4URRF.
        /// </summary>
        public const string L4URRF = "L4URRF";

        /// <summary>
        /// L4TORG.
        /// </summary>
        public const string L4TORG = "L4TORG";

        /// <summary>
        /// L4USER.
        /// </summary>
        public const string L4USER = "L4USER";

        /// <summary>
        /// L4PID.
        /// </summary>
        public const string L4PID = "L4PID";

        /// <summary>
        /// L4JOBN.
        /// </summary>
        public const string L4JOBN = "L4JOBN";

        /// <summary>
        /// L4UUPMJ.
        /// </summary>
        public const string L4UUPMJ = "L4UUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F00142";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("L4DDRL", "L4DDRL", JdeDataType.String, 10, true, true),
        new JdeField("L4DL01", "L4DL01", JdeDataType.String, 60),
        new JdeField("L4DABS", "L4DABS", JdeDataType.String, 2),
        new JdeField("L4DADD", "L4DADD", JdeDataType.Numeric),
        new JdeField("L4DYFX", "L4DYFX", JdeDataType.Numeric),
        new JdeField("L4MADD", "L4MADD", JdeDataType.Numeric),
        new JdeField("L4CALN", "L4CALN", JdeDataType.String, 24),
        new JdeField("L4WKDY", "L4WKDY", JdeDataType.String, 2),
        new JdeField("L4DSTRPAMT", "L4DSTRPAMT", JdeDataType.Numeric),
        new JdeField("L4DSTRDTE", "L4DSTRDTE", JdeDataType.Date),
        new JdeField("L4DLVPRC", "L4DLVPRC", JdeDataType.Numeric),
        new JdeField("L4ADVPMNT", "L4ADVPMNT", JdeDataType.String, 2),
        new JdeField("L4BSDON", "L4BSDON", JdeDataType.String, 6),
        new JdeField("L4URAT", "L4URAT", JdeDataType.Numeric),
        new JdeField("L4URCD", "L4URCD", JdeDataType.String, 4),
        new JdeField("L4URDT", "L4URDT", JdeDataType.Numeric),
        new JdeField("L4URAB", "L4URAB", JdeDataType.Numeric),
        new JdeField("L4URRF", "L4URRF", JdeDataType.String, 30),
        new JdeField("L4TORG", "L4TORG", JdeDataType.String, 20),
        new JdeField("L4USER", "L4USER", JdeDataType.String, 20),
        new JdeField("L4PID", "L4PID", JdeDataType.String, 20),
        new JdeField("L4JOBN", "L4JOBN", JdeDataType.String, 20),
        new JdeField("L4UUPMJ", "L4UUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00142_0", "Primary Key on L4DDRL", new[] { "L4DDRL" }, isUnique: true, isPrimaryKey: true)
    };
}
