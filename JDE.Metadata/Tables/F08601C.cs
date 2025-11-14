using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08601C - .
/// </summary>
public class F08601C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PICASE.
        /// </summary>
        public const string PICASE = "PICASE";

        /// <summary>
        /// PIERCHKBX.
        /// </summary>
        public const string PIERCHKBX = "PIERCHKBX";

        /// <summary>
        /// PIHCHKBX.
        /// </summary>
        public const string PIHCHKBX = "PIHCHKBX";

        /// <summary>
        /// PITMDY.
        /// </summary>
        public const string PITMDY = "PITMDY";

        /// <summary>
        /// PIFACAN8.
        /// </summary>
        public const string PIFACAN8 = "PIFACAN8";

        /// <summary>
        /// PIUSER.
        /// </summary>
        public const string PIUSER = "PIUSER";

        /// <summary>
        /// PIPID.
        /// </summary>
        public const string PIPID = "PIPID";

        /// <summary>
        /// PIUPMJ.
        /// </summary>
        public const string PIUPMJ = "PIUPMJ";

        /// <summary>
        /// PIUPMT.
        /// </summary>
        public const string PIUPMT = "PIUPMT";

        /// <summary>
        /// PIJOBN.
        /// </summary>
        public const string PIJOBN = "PIJOBN";

        /// <summary>
        /// PIEV01.
        /// </summary>
        public const string PIEV01 = "PIEV01";

        /// <summary>
        /// PIEV02.
        /// </summary>
        public const string PIEV02 = "PIEV02";

        /// <summary>
        /// PIMATH01.
        /// </summary>
        public const string PIMATH01 = "PIMATH01";

        /// <summary>
        /// PIMATH02.
        /// </summary>
        public const string PIMATH02 = "PIMATH02";

        /// <summary>
        /// PIDTA1.
        /// </summary>
        public const string PIDTA1 = "PIDTA1";

        /// <summary>
        /// PIDTA2.
        /// </summary>
        public const string PIDTA2 = "PIDTA2";

        /// <summary>
        /// PIDATE01.
        /// </summary>
        public const string PIDATE01 = "PIDATE01";

        /// <summary>
        /// PIDATE02.
        /// </summary>
        public const string PIDATE02 = "PIDATE02";

        /// <summary>
        /// PIHHAMP.
        /// </summary>
        public const string PIHHAMP = "PIHHAMP";

        /// <summary>
        /// PIHHFAT.
        /// </summary>
        public const string PIHHFAT = "PIHHFAT";

        /// <summary>
        /// PIHHEYE.
        /// </summary>
        public const string PIHHEYE = "PIHHEYE";
    }

    /// <inheritdoc />
    public override string TableName => "F08601C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PICASE", "PICASE", JdeDataType.Numeric, null, true, true),
        new JdeField("PIERCHKBX", "PIERCHKBX", JdeDataType.String, 2),
        new JdeField("PIHCHKBX", "PIHCHKBX", JdeDataType.String, 2),
        new JdeField("PITMDY", "PITMDY", JdeDataType.Numeric),
        new JdeField("PIFACAN8", "PIFACAN8", JdeDataType.Numeric),
        new JdeField("PIUSER", "PIUSER", JdeDataType.String, 20),
        new JdeField("PIPID", "PIPID", JdeDataType.String, 20),
        new JdeField("PIUPMJ", "PIUPMJ", JdeDataType.Numeric),
        new JdeField("PIUPMT", "PIUPMT", JdeDataType.Numeric),
        new JdeField("PIJOBN", "PIJOBN", JdeDataType.String, 20),
        new JdeField("PIEV01", "PIEV01", JdeDataType.String, 2),
        new JdeField("PIEV02", "PIEV02", JdeDataType.String, 2),
        new JdeField("PIMATH01", "PIMATH01", JdeDataType.Numeric),
        new JdeField("PIMATH02", "PIMATH02", JdeDataType.Numeric),
        new JdeField("PIDTA1", "PIDTA1", JdeDataType.String, 512),
        new JdeField("PIDTA2", "PIDTA2", JdeDataType.String, 512),
        new JdeField("PIDATE01", "PIDATE01", JdeDataType.Numeric),
        new JdeField("PIDATE02", "PIDATE02", JdeDataType.Numeric),
        new JdeField("PIHHAMP", "PIHHAMP", JdeDataType.String, 2),
        new JdeField("PIHHFAT", "PIHHFAT", JdeDataType.String, 2),
        new JdeField("PIHHEYE", "PIHHEYE", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08601C_0", "Primary Key on PICASE", new[] { "PICASE" }, isUnique: true, isPrimaryKey: true)
    };
}
