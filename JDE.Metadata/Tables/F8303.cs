using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F8303 - .
/// </summary>
public class F8303 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R3PID.
        /// </summary>
        public const string R3PID = "R3PID";

        /// <summary>
        /// R3VERS.
        /// </summary>
        public const string R3VERS = "R3VERS";

        /// <summary>
        /// R3SQNC.
        /// </summary>
        public const string R3SQNC = "R3SQNC";

        /// <summary>
        /// R3PRFX.
        /// </summary>
        public const string R3PRFX = "R3PRFX";

        /// <summary>
        /// R3DICT.
        /// </summary>
        public const string R3DICT = "R3DICT";

        /// <summary>
        /// R3DTAT.
        /// </summary>
        public const string R3DTAT = "R3DTAT";

        /// <summary>
        /// R3LEN.
        /// </summary>
        public const string R3LEN = "R3LEN";

        /// <summary>
        /// R3RSQN.
        /// </summary>
        public const string R3RSQN = "R3RSQN";

        /// <summary>
        /// R3RSQO.
        /// </summary>
        public const string R3RSQO = "R3RSQO";

        /// <summary>
        /// R3PGBK.
        /// </summary>
        public const string R3PGBK = "R3PGBK";

        /// <summary>
        /// R3TOT.
        /// </summary>
        public const string R3TOT = "R3TOT";

        /// <summary>
        /// R3VALR.
        /// </summary>
        public const string R3VALR = "R3VALR";

        /// <summary>
        /// R3SLVA.
        /// </summary>
        public const string R3SLVA = "R3SLVA";

        /// <summary>
        /// R3VA01.
        /// </summary>
        public const string R3VA01 = "R3VA01";

        /// <summary>
        /// R3VA02.
        /// </summary>
        public const string R3VA02 = "R3VA02";

        /// <summary>
        /// R3VA03.
        /// </summary>
        public const string R3VA03 = "R3VA03";

        /// <summary>
        /// R3VA04.
        /// </summary>
        public const string R3VA04 = "R3VA04";

        /// <summary>
        /// R3VA05.
        /// </summary>
        public const string R3VA05 = "R3VA05";

        /// <summary>
        /// R3VA06.
        /// </summary>
        public const string R3VA06 = "R3VA06";

        /// <summary>
        /// R3VA07.
        /// </summary>
        public const string R3VA07 = "R3VA07";

        /// <summary>
        /// R3VA08.
        /// </summary>
        public const string R3VA08 = "R3VA08";

        /// <summary>
        /// R3VA09.
        /// </summary>
        public const string R3VA09 = "R3VA09";

        /// <summary>
        /// R3VA10.
        /// </summary>
        public const string R3VA10 = "R3VA10";

        /// <summary>
        /// R3VA11.
        /// </summary>
        public const string R3VA11 = "R3VA11";

        /// <summary>
        /// R3VA12.
        /// </summary>
        public const string R3VA12 = "R3VA12";

        /// <summary>
        /// R3VA13.
        /// </summary>
        public const string R3VA13 = "R3VA13";

        /// <summary>
        /// R3VA14.
        /// </summary>
        public const string R3VA14 = "R3VA14";

        /// <summary>
        /// R3VA15.
        /// </summary>
        public const string R3VA15 = "R3VA15";

        /// <summary>
        /// R3VA16.
        /// </summary>
        public const string R3VA16 = "R3VA16";

        /// <summary>
        /// R3VA17.
        /// </summary>
        public const string R3VA17 = "R3VA17";

        /// <summary>
        /// R3VA18.
        /// </summary>
        public const string R3VA18 = "R3VA18";

        /// <summary>
        /// R3VA19.
        /// </summary>
        public const string R3VA19 = "R3VA19";

        /// <summary>
        /// R3VA20.
        /// </summary>
        public const string R3VA20 = "R3VA20";

        /// <summary>
        /// R3VA21.
        /// </summary>
        public const string R3VA21 = "R3VA21";

        /// <summary>
        /// R3VA22.
        /// </summary>
        public const string R3VA22 = "R3VA22";

        /// <summary>
        /// R3VA23.
        /// </summary>
        public const string R3VA23 = "R3VA23";

        /// <summary>
        /// R3VA24.
        /// </summary>
        public const string R3VA24 = "R3VA24";

        /// <summary>
        /// R3VA25.
        /// </summary>
        public const string R3VA25 = "R3VA25";

        /// <summary>
        /// R3VA26.
        /// </summary>
        public const string R3VA26 = "R3VA26";

        /// <summary>
        /// R3VA27.
        /// </summary>
        public const string R3VA27 = "R3VA27";

        /// <summary>
        /// R3VA28.
        /// </summary>
        public const string R3VA28 = "R3VA28";

        /// <summary>
        /// R3VA29.
        /// </summary>
        public const string R3VA29 = "R3VA29";

        /// <summary>
        /// R3VA30.
        /// </summary>
        public const string R3VA30 = "R3VA30";

        /// <summary>
        /// R3VA31.
        /// </summary>
        public const string R3VA31 = "R3VA31";

        /// <summary>
        /// R3VA32.
        /// </summary>
        public const string R3VA32 = "R3VA32";
    }

    /// <inheritdoc />
    public override string TableName => "F8303";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R3PID", "R3PID", JdeDataType.String, 20, true, true),
        new JdeField("R3VERS", "R3VERS", JdeDataType.String, 20, true, true),
        new JdeField("R3SQNC", "R3SQNC", JdeDataType.Numeric, null, true, true),
        new JdeField("R3PRFX", "R3PRFX", JdeDataType.String, 4),
        new JdeField("R3DICT", "R3DICT", JdeDataType.String, 8),
        new JdeField("R3DTAT", "R3DTAT", JdeDataType.String, 2),
        new JdeField("R3LEN", "R3LEN", JdeDataType.String, 4),
        new JdeField("R3RSQN", "R3RSQN", JdeDataType.String, 2),
        new JdeField("R3RSQO", "R3RSQO", JdeDataType.String, 2),
        new JdeField("R3PGBK", "R3PGBK", JdeDataType.String, 2),
        new JdeField("R3TOT", "R3TOT", JdeDataType.String, 2),
        new JdeField("R3VALR", "R3VALR", JdeDataType.String, 4),
        new JdeField("R3SLVA", "R3SLVA", JdeDataType.String, 24),
        new JdeField("R3VA01", "R3VA01", JdeDataType.String, 24),
        new JdeField("R3VA02", "R3VA02", JdeDataType.String, 24),
        new JdeField("R3VA03", "R3VA03", JdeDataType.String, 24),
        new JdeField("R3VA04", "R3VA04", JdeDataType.String, 24),
        new JdeField("R3VA05", "R3VA05", JdeDataType.String, 24),
        new JdeField("R3VA06", "R3VA06", JdeDataType.String, 24),
        new JdeField("R3VA07", "R3VA07", JdeDataType.String, 24),
        new JdeField("R3VA08", "R3VA08", JdeDataType.String, 24),
        new JdeField("R3VA09", "R3VA09", JdeDataType.String, 24),
        new JdeField("R3VA10", "R3VA10", JdeDataType.String, 24),
        new JdeField("R3VA11", "R3VA11", JdeDataType.String, 24),
        new JdeField("R3VA12", "R3VA12", JdeDataType.String, 24),
        new JdeField("R3VA13", "R3VA13", JdeDataType.String, 24),
        new JdeField("R3VA14", "R3VA14", JdeDataType.String, 24),
        new JdeField("R3VA15", "R3VA15", JdeDataType.String, 24),
        new JdeField("R3VA16", "R3VA16", JdeDataType.String, 24),
        new JdeField("R3VA17", "R3VA17", JdeDataType.String, 24),
        new JdeField("R3VA18", "R3VA18", JdeDataType.String, 24),
        new JdeField("R3VA19", "R3VA19", JdeDataType.String, 24),
        new JdeField("R3VA20", "R3VA20", JdeDataType.String, 24),
        new JdeField("R3VA21", "R3VA21", JdeDataType.String, 24),
        new JdeField("R3VA22", "R3VA22", JdeDataType.String, 24),
        new JdeField("R3VA23", "R3VA23", JdeDataType.String, 24),
        new JdeField("R3VA24", "R3VA24", JdeDataType.String, 24),
        new JdeField("R3VA25", "R3VA25", JdeDataType.String, 24),
        new JdeField("R3VA26", "R3VA26", JdeDataType.String, 24),
        new JdeField("R3VA27", "R3VA27", JdeDataType.String, 24),
        new JdeField("R3VA28", "R3VA28", JdeDataType.String, 24),
        new JdeField("R3VA29", "R3VA29", JdeDataType.String, 24),
        new JdeField("R3VA30", "R3VA30", JdeDataType.String, 24),
        new JdeField("R3VA31", "R3VA31", JdeDataType.String, 24),
        new JdeField("R3VA32", "R3VA32", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F8303_0", "Primary Key on R3PID, R3VERS, R3SQNC", new[] { "R3PID", "R3VERS", "R3SQNC" }, isUnique: true, isPrimaryKey: true)
    };
}
